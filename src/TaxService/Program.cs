using Serilog;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
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
                    builder.ConfigureWithSubstitution(context)
                )
                .UseSerilog((context, services, builder) => builder
                    .ReadFrom.Configuration(context.Configuration)
                    .ReadFrom.Services(services));
    }
}
