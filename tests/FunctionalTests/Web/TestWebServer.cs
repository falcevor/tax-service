using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using TaxService;
using TaxService.Data.DataContext;

namespace FunctionalTests.Web
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
                o.UseSetting("UseInMemoryDatabase", "true");

                o.ConfigureAppConfiguration((context, builder) => 
                    builder.Properties["UseInMemoryDatabase"] = true);
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
                                //TODO: обогатить тестовую БД данными
                            }
                            catch (Exception ex)
                            {
                                logger.LogError(ex, $"An error occurred seeding the " +
                                    "database with test messages. Error: {ex.Message}");
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
