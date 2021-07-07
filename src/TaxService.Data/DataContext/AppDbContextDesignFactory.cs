using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
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
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseNpgsql(config.GetConnectionString("Default"));
            return new AppDbContext(builder.Options);
        }
    }
}
