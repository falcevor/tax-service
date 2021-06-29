using Microsoft.Extensions.DependencyInjection;
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
            services.AddDbContext<AppDbContext>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<ITaxRepository, TaxRepository>();
            services.AddTransient<IAsyncRepository<Taxpayer>, TaxpayerRepository>();

            return services;
        }
    }
}
