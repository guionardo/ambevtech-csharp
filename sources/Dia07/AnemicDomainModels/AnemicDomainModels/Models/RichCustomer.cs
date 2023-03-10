using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnemicDomainModels.Models
{
    public class RichCustomer
    {
        /// <summary>
        /// Identificador do cliente
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Documento CPF/CNPJ do cliente
        /// </summary>
        [JsonPropertyName("document")]
        [JsonConverter(typeof(DocumentJsonSerializer))]
        public Document Document { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        [JsonPropertyName("phone_number")]
        [JsonConverter(typeof(PhoneNumberJsonConverter))]
        public PhoneNumber PhoneNumber { get; set; }
    }
}
