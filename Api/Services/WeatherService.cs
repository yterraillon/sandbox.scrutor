namespace Api.Services;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetNextForecasts();
}

public class WeatherService : IWeatherService
{
    private readonly ILogger<WeatherService> _logger;

    public WeatherService(ILogger<WeatherService> logger) => _logger = logger;

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    public IEnumerable<WeatherForecast> GetNextForecasts()
    {
        _logger.LogInformation("WeatherService was called");
        
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
}