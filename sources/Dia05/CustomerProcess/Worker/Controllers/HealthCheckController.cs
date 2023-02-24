using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Worker.Controllers
{
    [Route("health")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("liveness")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
