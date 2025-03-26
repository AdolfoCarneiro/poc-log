
using Application;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Logging.ApplicationInsights;

namespace poc_log
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IAnyService, AnyService>();
            builder.Services.AddApplicationInsightsTelemetry();
            builder.Services.AddLogging(builder => builder.AddApplicationInsights());
            builder.Logging.AddApplicationInsights() ;

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();



                app.UseSwagger();
                app.UseSwaggerUI();
            
            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
