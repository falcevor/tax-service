using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Data.DataContext;
using TaxService.Domain.Model;

namespace TaxService.Data.Repositories
{
    public class AreaRepository : IAsyncRepository<Area>
    {
        private readonly AppDbContext _db;

        public AreaRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<int> CreateAsync(Area item, CancellationToken cancelationToken)
        {
            await _db.AddAsync(item, cancelationToken);
            await _db.SaveChangesAsync(cancelationToken);
            return item.Id;
        }

        public Task DeleteAsync(int id, CancellationToken cancelationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Area>> GetAllAsync(CancellationToken cancelationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Area> GetAsync(int id, CancellationToken cancelationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Area item, CancellationToken cancelationToken)
        {
            throw new NotImplementedException();
        }
    }
}
