using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxService.Domain.Model;
using TaxService.Data.DataContext;
using AutoMapper;
using TaxService.Data.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TaxService.Application.Repositories;

namespace TaxService.Data
{
    public class TaxRepository : ITaxRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public TaxRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IAsyncEnumerable<Income> GetIncomesAsync(int taxpayerId, DateTime from, DateTime to)
        {
            return _mapper.ProjectTo<Income>(_db.Incomes
                    .AsNoTracking())
                .ToAsyncEnumerable()
                .Where(x => x.Id == taxpayerId) //TODO: поправить
                .Where(x => x.Date >= from && x.Date <= to);
        }

        public IAsyncEnumerable<Payment> GetPaymentsAsync(int taxpayerId, DateTime from, DateTime to)
        {
            return _mapper.ProjectTo<Payment>(_db.Payments
                    .AsNoTracking())
                .ToAsyncEnumerable()
                .Where(x => x.Id == taxpayerId) //TODO: поправить
                .Where(x => x.Date >= from && x.Date <= to);
        }

        public async Task<ReportTemplate> GetReportTemplateAsync(int templateId)
        {
            var tempalte = await _db.ReportTemplates.FindAsync(templateId);
            return _mapper.Map<ReportTemplate>(tempalte);
        }

        public IAsyncEnumerable<ReportTemplate> GetReportTemplatesAsync()
        {
            return _mapper.ProjectTo<ReportTemplate>(_db.ReportTemplates
                    .AsNoTracking())
                .ToAsyncEnumerable();
        }

        public async Task<Taxpayer> GetTaxpayerAsync(int taxpayerId)
        {
            var taxpayer = await _db.Taxpayers.FindAsync(taxpayerId);
            return _mapper.Map<Taxpayer>(taxpayer);
        }

        public IAsyncEnumerable<Taxpayer> GetTaxpayersAsync(int inspectorId)
        {
            return _mapper.ProjectTo<Taxpayer>(_db.Taxpayers
                    .AsNoTracking())
                .ToAsyncEnumerable();
        }

        public async Task<int> SaveReportTemplateAsync(ReportTemplate template)
        {
            var tempalteDto = _mapper.Map<ReportTemplateDto>(template);
            _db.ReportTemplates.Attach(tempalteDto);
            await _db.SaveChangesAsync();
            return await Task.FromResult(tempalteDto.Id);
        }

        public async Task<int> SaveTaxpayerAsync(int inspectorId, Taxpayer taxpayer)
        {
            var taxpayerDto = _mapper.Map<ReportTemplateDto>(taxpayer);
            _db.ReportTemplates.Attach(taxpayerDto);
            await _db.SaveChangesAsync();
            return await Task.FromResult(taxpayerDto.Id);
        }
    }
}
