namespace Api.Services;

public class LoggingDecorator : IWeatherService
{
    private readonly ILogger<LoggingDecorator> _logger;
    private readonly IWeatherService _weatherService;

    public LoggingDecorator(ILogger<LoggingDecorator> logger, IWeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    public IEnumerable<WeatherForecast> GetNextForecasts()
    {
        _logger.LogInformation("Decorator was called");
        return _weatherService.GetNextForecasts();
    }
}