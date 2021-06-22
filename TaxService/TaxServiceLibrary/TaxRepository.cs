using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TaxServiceDataAccess;
using TaxServiceLibrary.Model;

namespace TaxServiceLibrary
{
    public class TaxRepository : ITaxRepository
    {

        public ReportTemplate GetReportTemplateInfo(int templateId)
        {
            using (var provider = new PostgreTaxServiceDataProvider())
            {
                try
                {
      
                    var data = provider.GetReportTemplateInfoById(templateId);

                    DataRow row = data.Rows[0];
                 
                    var tempateId = Int32.Parse(row["id"].ToString());
                    var templateParams = new List<ReportTemplateParameter>();
                    var paramList = provider.GetTemplateParameterInfoByTemplateId(tempateId);

                    foreach (var param in paramList.Rows.Cast<DataRow>())
                    {
                        templateParams.Add(new ReportTemplateParameter()
                        {
                            id = Int32.Parse(param["id"].ToString()),
                            name = param["name"].ToString(),
                            description = param["description"].ToString(),
                            defaultValue = param["default_value"].ToString()
                        });
                    }

                    var template = row["file"] as byte[];
                    if (template == null) return null;

                    var info = new ReportTemplate()
                    {
                        id = tempateId,
                        name = row["name"].ToString(),
                        description = row["description"].ToString(),
                        file = template,
                        parameters = templateParams.ToArray()
                    };
                    return info;   
                }
                catch
                {
                    return null;
                }
            }
        }

        public Taxpayer GetTaxpayerInfo(int taxpayerId)
        {
            using (var provider = new PostgreTaxServiceDataProvider())
            {
                try
                {
                    var data = provider.GetTaxpayerInfoById(taxpayerId);
                    var row = data.Rows.Cast<DataRow>().First();
                    var attachs = new List<Document>();
                    var docs = provider.GetDocumentsByTaxpayerId(Int32.Parse(row["id"].ToString()));
                    foreach (var docRow in docs.Rows.Cast<DataRow>())
                    {
                        var file = docRow["file"] as byte[];
                        if (file == null) continue;
                        attachs.Add(new Document()
                        {
                            id = Int32.Parse(docRow["id"].ToString()),
                            name = docRow["name"].ToString(),
                            description = docRow["description"].ToString(),
                            file = file
                        });
                    }

                    var info = new Taxpayer()
                    {
                        id = Int32.Parse(row["id"].ToString()),
                        inn = row["inn"].ToString(),
                        kpp = row["kpp"].ToString(),
                        name = row["name"].ToString(),
                        category = row["category_name"].ToString(),
                        taxType = row["tax_type_name"].ToString(),
                        placeType = row["place_type_name"].ToString(),
                        percent = Int32.Parse(row["tax_percent"].ToString()),
                        placeAddress = row["place_address"].ToString(),
                        additionalInfo = row["additional_info"].ToString(),
                        beginDate = DateTime.Parse(row["begin_date"].ToString()),
                        documents = attachs.ToArray()
                    };
                    return info;
                }
                catch
                {
                    return null;
                }
            }
        }

        public int Login(string login, string password)
        {
            using (var provider = new PostgreTaxServiceDataProvider())
            {
                try
                {
                    var data = provider.GetInspectorInfoByName(login);
                    var pass = data.Rows[0]["password"].ToString();
                    var id = Int32.Parse(data.Rows[0]["id"].ToString());
                    return password == pass ? id : -1;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public bool SaveReportTemplateInfo(ReportTemplate info)
        {
            using (var provider = new PostgreTaxServiceDataProvider())
            {
                try
                {
                    var templateId = info.id;
                    if (templateId == -1)
                    {
                        templateId = provider.CreateReportTemplateInfo(info.name, info.description, info.file);
                    }
                    else
                    {
                        provider.UpdateReportTemplateInfo(info.id, info.name, info.description, info.file);
                    }

                    provider.DeleteAllTemplateParameters(templateId);

                    foreach (var doc in info.parameters)
                    {
                        provider.UpdateReportTemplateParameter(templateId, doc.id, doc.name, doc.description, doc.defaultValue);
                    }

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool SaveTaxpayerInfo(int inspectorId, Taxpayer info)
        {
            using (var provider = new PostgreTaxServiceDataProvider())
            {
                try
                {
                    var taxpayerId = info.id;
                    if (taxpayerId == -1)
                    {
                        taxpayerId = provider.CreateTaxpayerInfo(inspectorId, info.inn, info.kpp, info.name,
                            info.category, info.taxType, info.percent, info.placeType, info.placeAddress,
                            info.beginDate, info.additionalInfo);
                    }
                    else
                    {
                        provider.UpdateTaxpayerInfo(info.id, info.inn, info.kpp, info.name,
                            info.category, info.taxType, info.percent, info.placeType, info.placeAddress,
                            info.beginDate, info.additionalInfo);
                    }

                    provider.DeleteAllTaxpayerDocuments(taxpayerId);

                    foreach (var doc in info.documents)
                    {
                        provider.UpdateTaxpayerDocument(taxpayerId, doc.id, doc.name, doc.description, doc.file);
                    }

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        ReportTemplate[] ITaxRepository.GetReportTemplateList()
        {
            using (var provider = new PostgreTaxServiceDataProvider())
            {
                try
                {
                    var result = new List<ReportTemplate>();
                    var data = provider.GetAllReportTemplates();

                    foreach (var row in data.Rows.Cast<DataRow>())
                    {
                        var tempateId = Int32.Parse(row["id"].ToString());
                        var templateParams = new List<ReportTemplateParameter>();
                        var paramList = provider.GetTemplateParameterInfoByTemplateId(tempateId);

                        foreach (var param in paramList.Rows.Cast<DataRow>())
                        {
                            templateParams.Add(new ReportTemplateParameter()
                            {
                                id = Int32.Parse(param["id"].ToString()),
                                name = param["name"].ToString(),
                                description = param["description"].ToString(),
                                defaultValue = param["default_value"].ToString()
                            });
                        }

                        var template = row["file"] as byte[];
                        if (template == null) continue;

                        var info = new ReportTemplate()
                        {
                            id = tempateId,
                            name = row["name"].ToString(),
                            description = row["description"].ToString(),
                            //file = template,
                            parameters = templateParams.ToArray()
                        };
                        result.Add(info);
                    }
                    return result.ToArray();
                }
                catch
                {
                    return null;
                }
            }
        }

        Taxpayer[] ITaxRepository.GetTaxpayerList(int inspectorId)
        {
            using (var provider = new PostgreTaxServiceDataProvider())
            {
                try
                {
                    var result = new List<Taxpayer>();
                    var data = provider.GetTaxpayersByInspectorId(inspectorId);

                    foreach (var row in data.Rows.Cast<DataRow>())
                    {
                        var attachs = new List<Document>();
                        var docs = provider.GetDocumentsByTaxpayerId(Int32.Parse(row["id"].ToString()));
                        foreach (var docRow in docs.Rows.Cast<DataRow>())
                        {
                            var file = docRow["file"] as byte[];
                            if (file == null) continue;
                            attachs.Add(new Document()
                            {
                                id = Int32.Parse(docRow["id"].ToString()),
                                name = docRow["name"].ToString(),
                                description = docRow["description"].ToString(),
                                file = file
                            });
                        }

                        var info = new Taxpayer()
                        {
                            id = Int32.Parse(row["id"].ToString()),
                            inn = row["inn"].ToString(),
                            kpp = row["kpp"].ToString(),
                            name = row["name"].ToString(),
                            category = row["category_name"].ToString(),
                            taxType = row["tax_type_name"].ToString(),
                            placeType = row["place_type_name"].ToString(),
                            placeAddress = row["place_address"].ToString(),
                            additionalInfo = row["additional_info"].ToString(),
                            percent = Int32.Parse(row["tax_percent"].ToString()),
                            beginDate = DateTime.Parse(row["begin_date"].ToString()),
                            documents = attachs.ToArray()
                        };
                        result.Add(info);
                    }
                    return result.ToArray();
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
