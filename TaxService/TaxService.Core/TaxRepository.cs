using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxServiceLibrary.Model;

namespace TaxService.Core
{
    public class TaxRepository : ITaxRepository
    {
        public IAsyncEnumerable<FinOperation> GetIncomesAsync(int taxpayerId, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<FinOperation> GetPaymentsAsync(int taxpayerId, DateTime from, DateTime to)
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
