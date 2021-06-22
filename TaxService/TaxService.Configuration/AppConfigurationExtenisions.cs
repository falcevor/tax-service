using Microsoft.Extensions.Configuration;
using StackExchange.Utils;

namespace TaxService.Configuration
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
                    c => c.AddJsonFile("appsettings.json")
                        .AddJsonFile($"appsettings.{env}.json", true)
                );

            return builder;
        }
    }
}
