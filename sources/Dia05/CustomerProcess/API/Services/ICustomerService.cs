namespace API.Services
{
    public interface ICustomerService
    {
        /// <summary>
        /// Enfileirar o novo customer.
        /// Retorna Exceção em caso de erro
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        Task EnqueueCustomer(Domain.Customer customer);

        Task<long> GetCustomerCount();
    }
}
