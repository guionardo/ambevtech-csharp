namespace DI_02.Services
{
    public interface IForecaster
    {
        IEnumerable<WeatherForecast> GetForecasts();

        WeatherForecast GetOneForecast();
    }
}
