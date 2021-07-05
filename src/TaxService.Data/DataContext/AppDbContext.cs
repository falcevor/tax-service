using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TaxService.Domain.Model;

namespace TaxService.Data.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Document> Documents { get; private set; }
        public DbSet<Payment> Payments { get; private set; }
        public DbSet<Income> Incomes { get; private set; }
        public DbSet<ReportTemplate> ReportTemplates { get; private set; }
        public DbSet<Taxpayer> Taxpayers { get; private set; }

        private IConfiguration _config { get; set; }
        private ILoggerFactory _loggerFactory { get; set; }

        public AppDbContext(IConfiguration config, ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(_config.GetConnectionString("Default"));
            options.UseLoggerFactory(_loggerFactory);
        }
    }
}
