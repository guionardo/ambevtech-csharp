using Azure.Messaging.ServiceBus;
using Domain;
using MongoDB.Driver;
using System.Text.Json;

namespace Worker.Workers
{
    public class CustomerWorker : IHostedService
    {
        private ILogger<CustomerWorker> _logger;
        private ServiceBusProcessor _processor;
        private IMongoCollection<Customer> _collection;

        public CustomerWorker(ILogger<CustomerWorker> logger, Config config)
        {
            _logger = logger;
            var serviceBusClient = new ServiceBusClient(config.ServiceBusConnectionString);
            _processor = serviceBusClient.CreateProcessor(config.ServiceBusQueueName);
            _processor.ProcessMessageAsync += ReceiveMessage;
            _processor.ProcessErrorAsync += ReceiveErrorMessage;

            // MongoDB
            var mongoClient = new MongoClient(config.DatabaseConnectionString);
            var db = mongoClient.GetDatabase("csharp_training");
            _collection = db.GetCollection<Customer>("customers");
        }

        private Task ReceiveErrorMessage(ProcessErrorEventArgs arg)
        {
            _logger.LogError("ReceiveErrorMessage {0}", arg);
            return Task.CompletedTask;
        }

        private async Task ReceiveMessage(ProcessMessageEventArgs arg)
        {
            try
            {
                var customer = arg.Message.Body.ToObjectFromJson<Customer>();
                await _collection.InsertOneAsync(customer);
                await arg.CompleteMessageAsync(arg.Message);
                _logger.LogInformation("Customer received and saved {0}", customer);
            }
            catch(JsonException ex)
            {
                // Deu erro na deserialização da mensagem. JSON inválido
                await arg.DeadLetterMessageAsync(arg.Message);
                _logger.LogError("MENSAGEM INVÁLIDA {0}: {1}", arg.Message.ToString(),ex);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("serial"))
                {
                    // Deu erro na deserialização da mensagem. JSON inválido
                    await arg.DeadLetterMessageAsync(arg.Message);
                }
                else
                {
                    await arg.AbandonMessageAsync(arg.Message);
                }
                _logger.LogError("Failed to receive message {0}", ex);
            }
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _processor.StartProcessingAsync(cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await _processor.StopProcessingAsync(cancellationToken);
        }
    }
}
