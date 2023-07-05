using Microsoft.AspNetCore.Server.Kestrel.Core;
using Prometheus;
using Serilog;
using Serilog.Formatting.Json;

namespace Training.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IConfiguration configuration = GetConfiguration();

            try
            {
                AddPrometheus(configuration.GetValue<int>("Prometheus:Port")).Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.ConfigureKestrel(options =>
                {
                    options.ListenAnyIP(5001, listenOptions => listenOptions.Protocols = HttpProtocols.Http2);
                });
                webBuilder.UseStartup<Startup>();
            }).UseSerilog((hostingContext, services, config) =>
            {
                config.ReadFrom.Configuration(hostingContext.Configuration) // Reads additional configuration previoously set on appsettings.json or other sources
                      .ReadFrom.Services(services)
                      .Enrich.FromLogContext()
                      .WriteTo.File(new JsonFormatter(), "../logs/*.json");
            });
        private static IConfiguration GetConfiguration()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile($"appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
        private static KestrelMetricServer AddPrometheus(int port)
        {
            return new KestrelMetricServer(port);
        }
    }
}