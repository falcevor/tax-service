using IntegrationTests.Web.TestData;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Reflection;
using TaxService;
using TaxService.Data.DataContext;

namespace IntegrationTests.Web
{
    public class TestWebServer : IDisposable
    {
        private readonly WebApplicationFactory<Startup> _appFactory;
        public HttpClient Client { get; }

        public TestWebServer()
        {
            _appFactory = new WebApplicationFactory<Startup>().WithWebHostBuilder(o =>
            {
                o.UseEnvironment("Testing");

                o.ConfigureAppConfiguration(configBuilder => {
                    configBuilder.Sources.Clear();
                    configBuilder.AddUserSecrets(Assembly.GetExecutingAssembly());
                    configBuilder.AddEnvironmentVariables();
                    });

                o.ConfigureServices(services =>
                {
                        var sp = services.BuildServiceProvider();

                        using (var scope = sp.CreateScope())
                        {
                            var scopedServices = scope.ServiceProvider;
                            var db = scopedServices.GetRequiredService<AppDbContext>();
                            var loggerFactory =
                                scopedServices.GetRequiredService<ILoggerFactory>();
                            var logger = scopedServices
                                .GetRequiredService<ILogger<TestWebServer>>();

                            db.Database.EnsureCreated();
                            try
                            {
                                TaxpayerSeed.SeedAsync(db).Wait();
                                InspectorSeed.SeedAsync(db).Wait();
                            }
                            catch (Exception ex)
                            {
                                logger.LogError(ex, $"An error occurred seeding the " +
                                    $"database with test data. Error: {ex.Message}");
                            }
                        }

                });
            });

            Client = _appFactory.CreateClient();
        }

        public void Dispose()
        {
            Client.Dispose();
            _appFactory.Dispose();
        }
    }
}
