using Microsoft.ApplicationInsights;
using Microsoft.Extensions.Logging;

namespace Application
{
    public class AnyService(ILogger<AnyService> logger, 
        TelemetryClient telemetryClient) : IAnyService
    {
        private readonly ILogger<AnyService> _logger = logger;
        private readonly TelemetryClient _telemetryClient = telemetryClient;

        public int DoAnithing()
        {
            _logger.LogInformation("Chamando DoAnithing info");
            _logger.LogWarning("Chamando DoAnithing warn");
            _logger.LogError("Chamando DoAnithing error");
            _logger.LogCritical("Chamando DoAnithing critical");
            _logger.LogDebug("Chamando DoAnithing debug");
            _logger.LogTrace("Chamando DoAnithing trace");

            var a = 1;
            var b = 2;
            var c = a + b;
            return c;
        }
    }
}
