using System;
using Serilog;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TaxService.Infrastructure.Configuration;

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
                .ConfigureAppConfiguration((context, builder) => 
                    builder.AddAppConfiguration(context.HostingEnvironment.EnvironmentName)
                )
                .ConfigureLogging(ConfigureLogging);

        private static void ConfigureLogging(HostBuilderContext context, ILoggingBuilder loggingBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddAppConfiguration(context.HostingEnvironment.EnvironmentName)
                .Build();
            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();
            loggingBuilder.AddSerilog(logger);
        }
    }
}
