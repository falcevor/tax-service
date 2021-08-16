using AutoMapper;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Create;
using TaxService.Application.Features.ReportTemplateFeature.Commands.Update;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetAll;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetById;
using TaxService.Application.Features.TaxpayerFeature.Commands.Create;
using TaxService.Application.Features.TaxpayerFeature.Commands.Update;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetAll;
using TaxService.Application.Features.TaxpayerFeature.Queries.GetById;
using TaxService.Domain.Model;

namespace TaxService.Application.Mappings
{
    public class RequestMapperProfile : Profile
    {
        public RequestMapperProfile()
        {
            CreateMap<CreateTaxpayerCommand, Taxpayer>();
            CreateMap<UpdateTaxpayerCommand, Taxpayer>();
            CreateMap<Taxpayer, GetTaxpayerByIdResponse>();
            CreateMap<Taxpayer, GetTaxpayersResponse>();
            CreateMap<ReportTemplate, GetReportTemplatesResponse>();
            CreateMap<CreateReportTemplateCommand, ReportTemplate>();
            CreateMap<UpdateReportTemplateCommand, ReportTemplate>();
            CreateMap<ReportTemplate, GetReportTemplateByIdResponse>();
        }
    }
}
