namespace Api.Services;

public interface ITemperatureService
{
    int GetTemperature();
}

public class CelsiusTemperatureService : ITemperatureService
{
    public int GetTemperature()
    {
        return Random.Shared.Next(-20, 55);
    }
}

public class KelvinTemperatureService : ITemperatureService
{
    public int GetTemperature()
    {
        return Random.Shared.Next(270, 300);
    }
}

public class FahrenheitTemperatureService : ITemperatureService
{
    public int GetTemperature()
    {
        return Random.Shared.Next(80, 150);
    }
}