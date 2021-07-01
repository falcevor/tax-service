using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Data.DataContext;
using TaxService.Data.Model;
using TaxService.Domain.Model;

namespace TaxService.Data.Repositories
{
    public class ReportTemplateRepository : IAsyncRepository<ReportTemplate>
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public ReportTemplateRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Task<IQueryable<ReportTemplate>> GetAllAsync(CancellationToken cancelationToken)
        {
            return Task.FromResult(
                _mapper.ProjectTo<ReportTemplate>(_db.ReportTemplates.AsNoTracking())
            );
        }

        public async Task CreateAsync(ReportTemplate item, CancellationToken cancelationToken)
        {
            var template = _mapper.Map<ReportTemplateDto>(item);
            await _db.ReportTemplates.AddAsync(template);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id, CancellationToken cancelationToken)
        {
            var temaplate = await _db.ReportTemplates.FindAsync(id);
            _db.ReportTemplates.Remove(temaplate);
            await _db.SaveChangesAsync();
        }

        public async Task<ReportTemplate> GetAsync(int id, CancellationToken cancelationToken)
        {
            var template = await _db.ReportTemplates.FindAsync(id);
            return _mapper.Map<ReportTemplate>(template);
        }

        public async Task UpdateAsync(ReportTemplate item, CancellationToken cancelationToken)
        {
            var template = _mapper.Map<ReportTemplate>(item);
            _db.Attach(template);
            await _db.SaveChangesAsync();
        }
    }
}
