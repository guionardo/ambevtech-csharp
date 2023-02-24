using Azure.Messaging.ServiceBus;
using Domain;
using System.Text.Json;
using MongoDB.Driver;

namespace API.Services
{
    public class CustomerService : ICustomerService
    {
        private Config _config;
        private ServiceBusClient _client;
        private ServiceBusSender _sender;
        private IMongoCollection<Customer> _collection;

        public CustomerService(Config config)
        {
            _config = config;
            // Service bus
            _client = new ServiceBusClient(config.ServiceBusConnectionString);
            _sender = _client.CreateSender(config.ServiceBusQueueName);

            // MongoDB
            var mongoClient = new MongoClient(config.DatabaseConnectionString);
            var db = mongoClient.GetDatabase("csharp_training");
            _collection = db.GetCollection<Customer>("customers");
        }
        public async Task EnqueueCustomer(Customer customer)
        {
            var jsonCustomer = JsonSerializer.Serialize(customer);
            if (jsonCustomer == null)
            {
                throw new NullReferenceException("NULL DATA FOR CUSTOMER");
            }
            var message = new ServiceBusMessage(jsonCustomer);
            await _sender.SendMessageAsync(message);
        }

        public async Task<long> GetCustomerCount()
        {
            var count = await _collection.CountDocumentsAsync(x => x.Id != "");
            return count;
        }
    }
}
