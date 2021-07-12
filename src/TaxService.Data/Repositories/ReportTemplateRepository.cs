using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Data.DataContext;
using TaxService.Domain.Model;

namespace TaxService.Data.Repositories
{
    public class ReportTemplateRepository : IAsyncRepository<ReportTemplate>
    {
        private readonly AppDbContext _db;

        public ReportTemplateRepository(AppDbContext db)
        {
            _db = db;
        }

        public Task<IQueryable<ReportTemplate>> GetAllAsync(CancellationToken cancelationToken)
        {
            return Task.FromResult(_db.ReportTemplates.AsNoTracking());
        }

        public async Task<int> CreateAsync(ReportTemplate item, CancellationToken cancelationToken)
        {
            await _db.ReportTemplates.AddAsync(item);
            await _db.SaveChangesAsync();
            return item.Id;
        }

        public async Task DeleteAsync(int id, CancellationToken cancelationToken)
        {
            var temaplate = await _db.ReportTemplates.FindAsync(id);
            _db.ReportTemplates.Remove(temaplate);
            await _db.SaveChangesAsync();
        }

        public async Task<ReportTemplate> GetAsync(int id, CancellationToken cancelationToken)
        {
            return await _db.ReportTemplates.FindAsync(id);
        }

        public async Task UpdateAsync(ReportTemplate item, CancellationToken cancelationToken)
        {
            _db.Attach(item);
            await _db.SaveChangesAsync();
        }
    }
}
