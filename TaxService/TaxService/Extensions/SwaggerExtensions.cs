using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace TaxService.Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddAppSwaggerServices(this IServiceCollection services)
        {
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            return services.AddSwaggerGen();
        }

        public static IApplicationBuilder UseAppSwaggerMiddleware(
            this IApplicationBuilder builder, 
            IApiVersionDescriptionProvider provider)
        {
            builder.UseSwagger();
            return builder.UseSwaggerUI(options =>
                provider.ApiVersionDescriptions
                    .ToList()
                    .ForEach(description => options.SwaggerEndpoint(
                        $"{description.GroupName}/swagger.json",
                        description.GroupName.ToUpperInvariant())
                )
            );
        }
    }
}
