using Api.Services;

namespace Api;

/// <summary>
/// https://github.com/khellang/Scrutor
/// https://andrewlock.net/using-scrutor-to-automatically-register-your-services-with-the-asp-net-core-di-container/
/// </summary>
public static class ServiceCollectionExtensions
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddTransient<IWeatherService, WeatherService>();
        services.Decorate<IWeatherService, LoggingDecorator>();
        
        return services;
    }
}