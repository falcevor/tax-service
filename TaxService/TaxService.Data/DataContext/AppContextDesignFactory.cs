using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TaxService.Configuration;

namespace TaxService.Data.DataContext
{
    public class AppContextDesignFactory : IDesignTimeDbContextFactory<AppDbContext>
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
