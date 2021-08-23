using Microsoft.EntityFrameworkCore;
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
        public DbSet<Inspector> Inspectors { get; private set; }

        public AppDbContext(DbContextOptions options) : base(options) { }
    }
}
