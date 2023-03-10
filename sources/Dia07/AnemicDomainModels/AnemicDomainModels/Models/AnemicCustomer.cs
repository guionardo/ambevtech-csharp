using System.Text.Json.Serialization;

namespace AnemicDomainModels.Models;

public class AnemicCustomer
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
    public string Document { get; set; }

    /// <summary>
    /// Telefone
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }
       
}