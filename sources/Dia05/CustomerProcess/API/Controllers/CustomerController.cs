using API.Dto;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerService _customerService;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService customerService)
        {
            _logger = logger;
            _customerService=customerService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Domain.Customer customer)
        {
            try
            {
                await _customerService.EnqueueCustomer(customer);
                _logger.LogInformation($"Enqueued customer {customer}");
                return Accepted();
            }catch(Exception ex)
            {
                _logger.LogError($"Failed to enqueue customer {customer} : {ex}");
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<CustomersCountResponse>> GetCustomersCount()
        {
            try
            {
                var count = await _customerService.GetCustomerCount();
                _logger.LogInformation($"Got {count} customers");
                return Ok(new CustomersCountResponse { 
                    Count = count
                });
            } catch(Exception ex)
            {
                _logger.LogError($"Failed getting customers count: {ex}");
                return BadRequest(ex.Message); // TODO: Implementar resposta de erro do servidor
            }
        }
    }
}
