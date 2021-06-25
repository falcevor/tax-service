using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TaxService.Application.Repositories;
using TaxService.Data.DataContext;

namespace TaxService.Data.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
            services.AddTransient<ITaxRepository, TaxRepository>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
