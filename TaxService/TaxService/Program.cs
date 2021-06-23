using System;
using Serilog;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using TaxService.Configuration;
using Microsoft.Extensions.Logging;

namespace TaxService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => 
                    webBuilder.UseStartup<Startup>()
                )
                .ConfigureAppConfiguration(configBuilder => 
                    configBuilder.AddAppConfiguration(GetEnvironment())
                )
                .ConfigureLogging(ConfigureLogging);


        private static void ConfigureLogging(ILoggingBuilder loggingBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddAppConfiguration(GetEnvironment())
                .Build();
            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();
            loggingBuilder.AddSerilog(logger);
        }

        private static string GetEnvironment()
        {
            return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";
        }
    }
}
