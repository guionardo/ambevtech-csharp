namespace AnemicDomainModels.Models;

public class AnemicCustomer
{
    /// <summary>
    /// Identificador do cliente
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Nome do cliente
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Documento CPF/CNPJ do cliente
    /// </summary>
    public string Document { get; set; }
    
    /// <summary>
    /// Telefone
    /// </summary>
    public string PhoneNumber { get; set; }
    
    
}