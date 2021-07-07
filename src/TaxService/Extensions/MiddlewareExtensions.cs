using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using TaxService.Middlewares;

namespace TaxService.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IServiceCollection AddAppMiddlewares(this IServiceCollection services)
        {
            services.AddScoped<ErrorHandlingMiddleware>();
            return services;
        }

        public static IApplicationBuilder UseAppMiddlewares(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ErrorHandlingMiddleware>();
            return builder;
        }
    }
}
