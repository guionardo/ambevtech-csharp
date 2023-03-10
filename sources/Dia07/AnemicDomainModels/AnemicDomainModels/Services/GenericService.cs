using AnemicDomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AnemicDomainModels.Services
{
    public class GenericService<T>
    {
        private readonly List<T> _customers;

        public GenericService()
        {
            _customers = new List<T>();
        }

        public void AddCustomer(T customer)
        {
            _customers.Add(customer);
        }

        public void AddCustomersFromJson(string json)
        {
            try
            {
                var customers = JsonSerializer.Deserialize<IEnumerable<T>>(json);
                if (customers != null)
                {
                    _customers.AddRange(customers);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Customers count: " + _customers.Count);
        }

        public string GetCustomersAsJson()
        {
            return JsonSerializer.Serialize(_customers);
        }
    }
}
