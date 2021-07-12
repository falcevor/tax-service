using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Data.DataContext;
using TaxService.Domain.Model;

namespace TaxService.Data.Repositories
{
    public class TaxpayerRepository : IAsyncRepository<Taxpayer>
    {
        private readonly AppDbContext _db;
        
        public TaxpayerRepository(AppDbContext db)
        {
            _db = db;
        }

        public Task<IQueryable<Taxpayer>> GetAllAsync(CancellationToken cancelationToken)
        {
            return Task.FromResult(_db.Taxpayers.AsNoTracking());
        }

        public async Task<int> CreateAsync(Taxpayer item, CancellationToken cancelationToken)
        {
            await _db.Taxpayers.AddAsync(item);
            await _db.SaveChangesAsync();
            return item.Id;
        }

        public async Task DeleteAsync(int id, CancellationToken cancelationToken)
        {
            var taxpayer = await _db.Taxpayers.FindAsync(id);
            _db.Taxpayers.Remove(taxpayer);
            await _db.SaveChangesAsync();
        }

        public async Task<Taxpayer> GetAsync(int id, CancellationToken cancelationToken)
        {
            return await _db.Taxpayers.FindAsync(id);
        }

        public async Task UpdateAsync(Taxpayer item, CancellationToken cancelationToken)
        {
            _db.Attach(item);
            await _db.SaveChangesAsync();
        }
    }
}
