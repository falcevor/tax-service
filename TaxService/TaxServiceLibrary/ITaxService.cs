using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaxServiceLibrary.Model;

namespace TaxServiceLibrary
{
    public interface ITaxService
    {
        IAsyncEnumerable<TaxpayerInfo> GetTaxpayersAsync(int inspectorId);

        IAsyncEnumerable<ReportTemplateInfo> GetReportTemplatesAsync();

        Task<TaxpayerInfo> GetTaxpayerAsync(int taxpayerId);

        Task<ReportTemplateInfo> GetReportTemplateAsync(int templateId);

        Task<bool> SaveTaxpayerAsync(int inspectorId, TaxpayerInfo info);

        Task<bool> SaveReportTemplateAsync(ReportTemplateInfo info);

        IAsyncEnumerable<FinOperationInfo> GetIncomesAsync(int taxpayerId, DateTime from, DateTime to);

        IAsyncEnumerable<FinOperationInfo> GetPaymentsAsync(int taxpayerId, DateTime from, DateTime to);
    }
}
