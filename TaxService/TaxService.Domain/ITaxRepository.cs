using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxService.Domain.Model;

namespace TaxService.Domain
{
    public interface ITaxRepository
    {
        IAsyncEnumerable<Taxpayer> GetTaxpayersAsync(int inspectorId);

        IAsyncEnumerable<ReportTemplate> GetReportTemplatesAsync();

        Task<Taxpayer> GetTaxpayerAsync(int taxpayerId);

        Task<ReportTemplate> GetReportTemplateAsync(int templateId);

        Task SaveTaxpayerAsync(int inspectorId, Taxpayer info);

        Task SaveReportTemplateAsync(ReportTemplate info);

        IAsyncEnumerable<Income> GetIncomesAsync(int taxpayerId, DateTime from, DateTime to);

        IAsyncEnumerable<Payment> GetPaymentsAsync(int taxpayerId, DateTime from, DateTime to);
    }
}
