using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TaxService.Infrastructure.Configuration;

namespace TaxService.Data.DataContext
{
    public class AppDbContextDesignFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddAppConfiguration("Development")
                .Build();
            return new AppDbContext(config, new LoggerFactory());
        }
    }
}
