using System;
using System.ServiceModel;
using TaxServiceLibrary.Model;

namespace TaxServiceLibrary
{
    [ServiceContract]
    public interface ITaxService
    {
        [OperationContract]
        int Login(string login, string password);

        [OperationContract]
        TaxpayerInfo[] GetTaxpayerList(int inspectorId);

        [OperationContract]
        ReportTemplateInfo[] GetReportTemplateList();

        [OperationContract]
        TaxpayerInfo GetTaxpayerInfo(int taxpayerId);

        [OperationContract]
        ReportTemplateInfo GetReportTemplateInfo(int templateId);

        [OperationContract]
        bool SaveTaxpayerInfo(int inspectorId, TaxpayerInfo info);

        [OperationContract]
        bool SaveReportTemplateInfo(ReportTemplateInfo info);

        [OperationContract]
        FinOperationInfo[] GetIncomes(int taxpayerId, DateTime from, DateTime to);

        [OperationContract]
        FinOperationInfo[] GetPayments(int taxpayerId, DateTime from, DateTime to);
    }
}
