using DI_02.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IForecaster _forecaster;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IForecaster forecaster)
        {
            _logger = logger;
            _forecaster = forecaster;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _forecaster.GetForecasts();
        }

        [HttpGet("somente_um")]
        public WeatherForecast GetOne()
        {
            return _forecaster.GetOneForecast();
        }
    }
}