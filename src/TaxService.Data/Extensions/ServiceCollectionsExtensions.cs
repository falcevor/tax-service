using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;
using TaxService.Application.Repositories;
using TaxService.Data.DataContext;
using TaxService.Data.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Data.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services)
        {
            services.ConfigureAppDbContext();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<IAsyncRepository<Taxpayer>, TaxpayerRepository>();
            services.AddTransient<IAsyncRepository<ReportTemplate>, ReportTemplateRepository>();
            services.AddTransient<IAsyncRepository<Area>, AreaRepository>();

            return services;
        }

        private static IServiceCollection ConfigureAppDbContext(this IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();
            var config = provider.GetRequiredService<IConfiguration>();

            if (config.GetValue("UseInMemoryDatabase", false))
            {

                var serviceProvider = services
                    .AddEntityFrameworkInMemoryDatabase()
                    .BuildServiceProvider();

                services.AddDbContext<AppDbContext>(options => options
                    .UseInMemoryDatabase("TestInMemoryDb")
                    .UseInternalServiceProvider(serviceProvider));
            }
            else
            {
                var connection = config.GetConnectionString("Default");
                var logFactory = provider.GetRequiredService<ILoggerFactory>();
                services.AddDbContext<AppDbContext>(options => options
                    .UseNpgsql(connection)
                    .UseLoggerFactory(logFactory));
            }

            return services;
        }
    }
}
