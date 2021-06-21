using System;
using TaxServiceLibrary.Model;

namespace TaxServiceLibrary
{
    public interface ITaxService
    {
        int Login(string login, string password);

        TaxpayerInfo[] GetTaxpayerList(int inspectorId);

        ReportTemplateInfo[] GetReportTemplateList();

        TaxpayerInfo GetTaxpayerInfo(int taxpayerId);

        ReportTemplateInfo GetReportTemplateInfo(int templateId);

        bool SaveTaxpayerInfo(int inspectorId, TaxpayerInfo info);

        bool SaveReportTemplateInfo(ReportTemplateInfo info);

        FinOperationInfo[] GetIncomes(int taxpayerId, DateTime from, DateTime to);

        FinOperationInfo[] GetPayments(int taxpayerId, DateTime from, DateTime to);
    }
}
