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
            CreateMap<CreateTaxpayerCommand, Taxpayer>()
                .ForMember(x => x.Id, y => y.Ignore())
                .ForMember(x => x.Category, y => y.Ignore())
                .ForMember(x => x.TaxType, y => y.Ignore())
                .ForMember(x => x.PlaceType, y => y.Ignore())
                .ForMember(x => x.Area, y => y.Ignore())
                .ForMember(x => x.Documents, y => y.Ignore())
                .ForMember(x => x.Payments, y => y.Ignore())
                .ForMember(x => x.Incomes, y => y.Ignore());

            CreateMap<UpdateTaxpayerCommand, Taxpayer>()
                .ForMember(x => x.Category, y => y.Ignore())
                .ForMember(x => x.TaxType, y => y.Ignore())
                .ForMember(x => x.PlaceType, y => y.Ignore())
                .ForMember(x => x.Area, y => y.Ignore())
                .ForMember(x => x.Documents, y => y.Ignore())
                .ForMember(x => x.Payments, y => y.Ignore())
                .ForMember(x => x.Incomes, y => y.Ignore());

            CreateMap<Taxpayer, GetTaxpayerByIdResponse>();
            
            CreateMap<Taxpayer, GetTaxpayersResponse>();
            
            CreateMap<ReportTemplate, GetReportTemplatesResponse>();
            
            CreateMap<CreateReportTemplateCommand, ReportTemplate>()
                .ForMember(x => x.Id, y => y.Ignore());

            CreateMap<UpdateReportTemplateCommand, ReportTemplate>();
            
            CreateMap<ReportTemplate, GetReportTemplateByIdResponse>();
        }
    }
}
