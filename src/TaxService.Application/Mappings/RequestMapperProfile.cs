using AutoMapper;
using TaxService.Application.Features.ReportTemplateFeature.Queries.GetAll;
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
            CreateMap<CreateTaxpayerCommand, Taxpayer>().ReverseMap();
            CreateMap<UpdateTaxpayerCommand, Taxpayer>().ReverseMap();
            CreateMap<Taxpayer, GetTaxpayerByIdResponse>().ReverseMap();
            CreateMap<Taxpayer, GetTaxpayersResponse>().ReverseMap();
            CreateMap<ReportTemplate, GetReportTemplatesResponse>().ReverseMap();
            
        }
    }
}
