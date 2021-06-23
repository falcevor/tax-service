using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace TaxService.Extensions
{
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            _provider.ApiVersionDescriptions
                .ToList()
                .ForEach(description =>
                    options.SwaggerDoc(
                        description.GroupName, 
                        new OpenApiInfo() 
                        { 
                            Title = $"Tax Service API v{description.ApiVersion}", 
                            Version = description.ApiVersion.ToString() 
                        })
                );
        }
    }
}
