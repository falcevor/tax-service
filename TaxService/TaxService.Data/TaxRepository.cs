using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxService.Domain.Model;
using TaxService.Data.DataContext;
using AutoMapper;
using TaxService.Data.Model;
using AutoMapper.QueryableExtensions;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TaxService.Application.Repositories;

namespace TaxService.Data
{
    public class TaxRepository : ITaxRepository
    {
        private readonly AppDbContext _db;
        private readonly IConfigurationProvider _mapperConfig;
        private readonly IMapper _mapper;

        public TaxRepository(AppDbContext db)
        {
            _db = db;
            _mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<DocumentDto, Document>();
                config.CreateMap<IncomeDto, Income>();
                config.CreateMap<PaymentDto, Payment>();
                config.CreateMap<ReportTemplateDto, ReportTemplate>();
                config.CreateMap<ReportTemplateParameterDto, ReportTemplateParameter>();
                config.CreateMap<TaxpayerDto, Taxpayer>();
                config.CreateMap<Taxpayer, TaxpayerDto>();
                config.CreateMap<ReportTemplate, ReportTemplateDto>();
            });
            _mapper = _mapperConfig.CreateMapper();
        }

        public IAsyncEnumerable<Income> GetIncomesAsync(int taxpayerId, DateTime from, DateTime to)
        {
            return _db.Incomes
                .AsNoTracking()
                .ProjectTo<Income>(_mapperConfig)
                .ToAsyncEnumerable()
                .Where(x => x.Id == taxpayerId) //TODO: поправить
                .Where(x => x.Date >= from && x.Date <= to);
        }

        public IAsyncEnumerable<Payment> GetPaymentsAsync(int taxpayerId, DateTime from, DateTime to)
        {
            return _db.Payments
                .AsNoTracking()
                .ProjectTo<Payment>(_mapperConfig)
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
            return _db.ReportTemplates
                .AsNoTracking()
                .ProjectTo<ReportTemplate>(_mapperConfig)
                .ToAsyncEnumerable();
        }

        public async Task<Taxpayer> GetTaxpayerAsync(int taxpayerId)
        {
            var taxpayer = await _db.Taxpayers.FindAsync(taxpayerId);
            return _mapper.Map<Taxpayer>(taxpayer);
        }

        public IAsyncEnumerable<Taxpayer> GetTaxpayersAsync(int inspectorId)
        {
            return _db.Taxpayers
                .AsNoTracking()
                .ProjectTo<Taxpayer>(_mapperConfig)
                .ToAsyncEnumerable();
        }

        public async Task SaveReportTemplateAsync(ReportTemplate template)
        {
            var tempalteDto = _mapper.Map<ReportTemplateDto>(template);
            _db.ReportTemplates.Attach(tempalteDto);
            await _db.SaveChangesAsync();
        }

        public async Task SaveTaxpayerAsync(int inspectorId, Taxpayer taxpayer)
        {
            var taxpayerDto = _mapper.Map<ReportTemplateDto>(taxpayer);
            _db.ReportTemplates.Attach(taxpayerDto);
            await _db.SaveChangesAsync();
        }
    }
}
