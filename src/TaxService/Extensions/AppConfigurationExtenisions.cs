using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using StackExchange.Utils;
using System.Reflection;

namespace TaxService.Infrastructure.Configuration
{
    public static class AppConfigurationExtenisions
    {
        public static IConfigurationBuilder ConfigureWithSubstitution(this IConfigurationBuilder builder, HostBuilderContext context)
        {
            var env = context.HostingEnvironment.EnvironmentName;
            return builder
                .WithPrefix(
                    "secrets",
                    c => c.AddUserSecrets(Assembly.GetExecutingAssembly())
                )
                .WithSubstitution(
                    c => c.AddJsonFile($"appsettings.json", optional: true, reloadOnChange: true)
                          .AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true)
                          .AddEnvironmentVariables()
                );
        }
    }
}
