
using Application;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

namespace poc_log
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IAnyService, AnyService>();

            builder.Services.AddApplicationInsightsTelemetry();
            builder.Logging.AddApplicationInsights();
            builder.Logging.AddConsole();
            builder.Services.AddLogging(logBuilder =>
            {
                logBuilder.AddConsole();
                logBuilder.SetMinimumLevel(LogLevel.Information);
                logBuilder.AddApplicationInsights(
                    configureTelemetryConfiguration: (config) => config.ConnectionString = "InstrumentationKey=baedcb7c-18c2-4e7d-9c6a-62e12bbad35f;IngestionEndpoint=https://canadacentral-1.in.applicationinsights.azure.com/;LiveEndpoint=https://canadacentral.livediagnostics.monitor.azure.com/;ApplicationId=c10c057c-f7ee-4f00-b30e-672467ef84f7",
                    configureApplicationInsightsLoggerOptions: (options) => { }
                    );
            });

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            //app.UseRouting();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
