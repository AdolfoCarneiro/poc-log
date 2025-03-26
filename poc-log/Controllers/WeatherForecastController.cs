using Application;
using Microsoft.AspNetCore.Mvc;

namespace poc_log.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> logger,
    IAnyService anyService
    ) : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger = logger;
    private readonly IAnyService _anyService = anyService;

    [HttpGet(Name = "GetWeatherForecast")]
    public int Get()
    {
        _logger.LogInformation("request no GetWeatherForecast");
        var response = _anyService.DoAnithing();
        return response;
    }
}
