using Microsoft.Extensions.Configuration;
using StackExchange.Utils;

namespace TaxService.Infrastructure.Configuration
{
    public static class AppConfigurationExtenisions
    {
        public static IConfigurationBuilder AddAppConfiguration(this IConfigurationBuilder builder, string env)
        {
            builder
                .WithPrefix(
                    "secrets",
                    c => c.AddUserSecrets(typeof(AppConfigurationExtenisions).Assembly)
                )
                .WithSubstitution(
                    c => c.AddJsonFile($"appsettings.json",       optional: true, reloadOnChange: true)
                          .AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true)
                );

            return builder;
        }
    }
}
