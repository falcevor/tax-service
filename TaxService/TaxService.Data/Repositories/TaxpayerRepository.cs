using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Data.DataContext;
using TaxService.Data.Model;
using TaxService.Domain.Model;

namespace TaxService.Data.Repositories
{
    public class TaxpayerRepository : IAsyncRespository<Taxpayer>
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public TaxpayerRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Task<IEnumerable<Taxpayer>> GetAllAsync(CancellationToken cancelationToken)
        {
            return Task.FromResult(
                _mapper.ProjectTo<Taxpayer>(_db.Taxpayers.AsNoTracking()).AsEnumerable()
            );
        }

        public async Task<int> CreateAsync(Taxpayer item, CancellationToken cancelationToken)
        {
            var taxpayer = _mapper.Map<TaxpayerDto>(item);
            await _db.Taxpayers.AddAsync(taxpayer);
            await _db.SaveChangesAsync();
            return await Task.FromResult(taxpayer.Id);
        }

        public async Task DeleteAsync(int id, CancellationToken cancelationToken)
        {
            var taxpayer = await _db.Taxpayers.FindAsync(id);
            _db.Taxpayers.Remove(taxpayer);
            await _db.SaveChangesAsync();
        }

        public async Task<Taxpayer> GetAsync(int id, CancellationToken cancelationToken)
        {
            var taxpayer = await _db.Taxpayers.FindAsync(id);
            return _mapper.Map<Taxpayer>(taxpayer);
        }

        public async Task UpdateAsync(Taxpayer item, CancellationToken cancelationToken)
        {
            var taxpayer = _mapper.Map<Taxpayer>(item);
            _db.Attach(taxpayer);
            await _db.SaveChangesAsync();
        }
    }
}
