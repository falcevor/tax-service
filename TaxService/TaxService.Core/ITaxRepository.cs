using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxServiceLibrary.Model;

namespace TaxService.Core
{
    public interface ITaxRepository
    {
        IAsyncEnumerable<Taxpayer> GetTaxpayersAsync(int inspectorId);

        IAsyncEnumerable<ReportTemplate> GetReportTemplatesAsync();

        Task<Taxpayer> GetTaxpayerAsync(int taxpayerId);

        Task<ReportTemplate> GetReportTemplateAsync(int templateId);

        Task<bool> SaveTaxpayerAsync(int inspectorId, Taxpayer info);

        Task<bool> SaveReportTemplateAsync(ReportTemplate info);

        IAsyncEnumerable<FinOperation> GetIncomesAsync(int taxpayerId, DateTime from, DateTime to);

        IAsyncEnumerable<FinOperation> GetPaymentsAsync(int taxpayerId, DateTime from, DateTime to);
    }
}
