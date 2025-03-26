using Application;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;

namespace poc_log.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> logger,
    IAnyService anyService,
    TelemetryClient telemetryClient
    ) : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger = logger;
    private readonly IAnyService _anyService = anyService;
    private readonly TelemetryClient _telemetryClient = telemetryClient;

    [HttpGet(Name = "GetWeatherForecast")]
    public int Get()
    {
        _logger.LogInformation("request no GetWeatherForecast");
        var response = _anyService.DoAnithing();
        return response;
    }
}
