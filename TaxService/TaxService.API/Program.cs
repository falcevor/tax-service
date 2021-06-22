using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using TaxService.Configuration;

namespace TaxService.API
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
                    configBuilder.AddAppConfiguration("Development")
                );
    }
}
