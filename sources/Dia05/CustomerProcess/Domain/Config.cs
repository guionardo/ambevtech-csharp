using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public record Config
    {
        public readonly string ServiceBusConnectionString;
        public readonly string ServiceBusQueueName;

        public readonly string DatabaseConnectionString;

        public Config()
        {
            ServiceBusConnectionString = Environment.GetEnvironmentVariable("SB_CONNECTIONSTRING") ?? "";
            if (string.IsNullOrWhiteSpace(ServiceBusConnectionString))
            {
                throw new ApplicationException("MISSED ENV SB_CONNECTIONSTRING");
            }

            ServiceBusQueueName = Environment.GetEnvironmentVariable("SB_QUEUENAME") ?? "";
            if (string.IsNullOrWhiteSpace(ServiceBusQueueName))
            {
                throw new ApplicationException("MISSED ENV SB_QUEUENAME");
            }

            DatabaseConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTIONSTRING") ?? "";
            if (string.IsNullOrWhiteSpace(DatabaseConnectionString))
            {
                throw new ApplicationException("MISSED ENV DB_CONNECTIONSTRING");
            }
        }
    }
}
