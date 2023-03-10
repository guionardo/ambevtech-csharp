using AnemicDomainModels.Models;

namespace AnemicDomainModels.Services;

public class CustomerService
{
    private readonly List<AnemicCustomer> _customers;

    public CustomerService()
    {
        _customers = new List<AnemicCustomer>();
    }

    public void AddCustomer(AnemicCustomer customer)
    {
        _customers.Add(customer);
    }
}