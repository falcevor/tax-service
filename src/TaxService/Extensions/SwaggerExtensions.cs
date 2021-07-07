using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Linq;

namespace TaxService.Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddAppSwaggerServices(this IServiceCollection services)
        {
            return services.AddSwaggerGen(opt =>
            {
                var serviceProvider = services.BuildServiceProvider();
                var versionProvider = serviceProvider.GetRequiredService<IApiVersionDescriptionProvider>();
                versionProvider.ApiVersionDescriptions.ToList()
                    .ForEach(desc => opt.SwaggerDoc(desc.GroupName, CreateApiInfo(desc)));

            });
        }

        public static IApplicationBuilder UseAppSwaggerMiddleware(
            this IApplicationBuilder builder, 
            IApiVersionDescriptionProvider provider)
        {
            builder.UseSwagger();
            return builder.UseSwaggerUI(opt =>
                provider.ApiVersionDescriptions.ToList()
                    .ForEach(desc => opt.SwaggerEndpoint($"{desc.GroupName}/swagger.json", desc.GroupName)
                )
            );
        }

        private static OpenApiInfo CreateApiInfo(ApiVersionDescription description)
        {
            return new OpenApiInfo()
            {
                Title = $"Tax Service API v{description.ApiVersion}",
                Version = description.ApiVersion.ToString()
            };
        }
    }
}
