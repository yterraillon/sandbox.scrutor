using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TemperatureController : ControllerBase
{
    private readonly CelsiusTemperatureService _celsiusTemperatureService;
    private readonly KelvinTemperatureService _kelvinTemperatureService;
    private readonly FahrenheitTemperatureService _fahrenheitTemperatureService;

    public TemperatureController(CelsiusTemperatureService celsiusTemperatureService, 
        KelvinTemperatureService kelvinTemperatureService,
        FahrenheitTemperatureService fahrenheitTemperatureService)
    {
        _celsiusTemperatureService = celsiusTemperatureService;
        _kelvinTemperatureService = kelvinTemperatureService;
        _fahrenheitTemperatureService = fahrenheitTemperatureService;
    }
    
    [HttpGet("GetTemperatureInC")]
    public int GetTempInC()
    {
        return _celsiusTemperatureService.GetTemperature();
    }
    
    [HttpGet("GetTemperatureInK")]
    public int GetTempInK()
    {
        return _kelvinTemperatureService.GetTemperature();
    }
    
    [HttpGet("GetTemperatureInF")]
    public int GetTempInF()
    {
        return _fahrenheitTemperatureService.GetTemperature();
    }
}