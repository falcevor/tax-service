using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Data.DataContext;
using TaxService.Domain.Model;

namespace TaxService.Data.Repositories
{
    public class InspectorRepository : IAsyncRepository<Inspector>
    {
        private AppDbContext _context;

        public InspectorRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<int> CreateAsync(Inspector item, CancellationToken cancelationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id, CancellationToken cancelationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IQueryable<Inspector>> GetAllAsync(CancellationToken cancelationToken)
        {
            return Task.FromResult(_context.Inspectors.AsNoTracking());
        }

        public Task<Inspector> GetAsync(int id, CancellationToken cancelationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Inspector item, CancellationToken cancelationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
