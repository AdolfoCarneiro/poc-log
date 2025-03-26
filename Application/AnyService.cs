using Microsoft.Extensions.Logging;

namespace Application
{
    public class AnyService : IAnyService
    {
        private readonly ILogger<AnyService> _logger;
        public AnyService(ILogger<AnyService> logger)
        {
            _logger = logger;
        }
        public int DoAnithing()
        {
            _logger.LogInformation("Chamando DoAnithing");
            var a = 1;
            var b = 2;
            var c = a + b;
            return c;
        }
    }
}
