using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxService.Core;
using TaxService.Core.Model;
using TaxService.Data.DataContext;

namespace TaxService.Data
{
    public class TaxRepository : ITaxRepository
    {
        private readonly AppDbContext _db;

        public TaxRepository(AppDbContext db)
        {
            _db = db;
        }

        public IAsyncEnumerable<Income> GetIncomesAsync(int taxpayerId, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<Payment> GetPaymentsAsync(int taxpayerId, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Task<ReportTemplate> GetReportTemplateAsync(int templateId)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<ReportTemplate> GetReportTemplatesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Taxpayer> GetTaxpayerAsync(int taxpayerId)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<Taxpayer> GetTaxpayersAsync(int inspectorId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveReportTemplateAsync(ReportTemplate info)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveTaxpayerAsync(int inspectorId, Taxpayer info)
        {
            throw new NotImplementedException();
        }
    }
}
