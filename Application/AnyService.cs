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
            _telemetryClient.TrackTrace("Chamando DoAnithing");
            var a = 1;
            var b = 2;
            var c = a + b;
            return c;
        }
    }
}
