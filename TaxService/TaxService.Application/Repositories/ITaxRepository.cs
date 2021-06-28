using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxService.Domain.Model;

namespace TaxService.Application.Repositories
{
    public interface ITaxRepository
    {
        IAsyncEnumerable<Taxpayer> GetTaxpayersAsync(int inspectorId);

        IAsyncEnumerable<ReportTemplate> GetReportTemplatesAsync();

        Task<Taxpayer> GetTaxpayerAsync(int taxpayerId);

        Task<ReportTemplate> GetReportTemplateAsync(int templateId);

        Task<int> SaveTaxpayerAsync(int inspectorId, Taxpayer info);

        Task<int> SaveReportTemplateAsync(ReportTemplate info);

        IAsyncEnumerable<Income> GetIncomesAsync(int taxpayerId, DateTime from, DateTime to);

        IAsyncEnumerable<Payment> GetPaymentsAsync(int taxpayerId, DateTime from, DateTime to);
    }
}
