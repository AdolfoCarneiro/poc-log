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
    public IEnumerable<int> Get()
    {
        var a = _anyService.DoAnithing();
    }
}
