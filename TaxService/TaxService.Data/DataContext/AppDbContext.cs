using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TaxService.Data.Model;

namespace TaxService.Data.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<DocumentDto> Documents { get; private set; }
        public DbSet<IncomeDto> Payments { get; private set; }
        public DbSet<PaymentDto> Incomes { get; private set; }
        public DbSet<ReportTemplateDto> ReportTemplates { get; private set; }
        public DbSet<TaxpayerDto> Taxpayers { get; private set; }

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
