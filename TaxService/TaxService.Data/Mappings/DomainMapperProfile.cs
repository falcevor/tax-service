using AutoMapper;
using TaxService.Data.Model;
using TaxService.Domain.Model;

namespace TaxService.Data.Mappings
{
    public class DomainMapperProfile : Profile
    {
        public DomainMapperProfile()
        {
            CreateMap<DocumentDto, Document>().ReverseMap();
            CreateMap<IncomeDto, Income>().ReverseMap();
            CreateMap<PaymentDto, Payment>().ReverseMap();
            CreateMap<ReportTemplateDto, ReportTemplate>().ReverseMap();
            CreateMap<ReportTemplateParameterDto, ReportTemplateParameter>().ReverseMap();
            CreateMap<TaxpayerDto, Taxpayer>().ReverseMap();
            CreateMap<TaxTypeDto, TaxType>().ReverseMap();
            CreateMap<TaxpayerCategoryDto, TaxpayerCategory>().ReverseMap();
            CreateMap<AreaDto, Area>().ReverseMap();
            CreateMap<InspectorDto, Inspector>().ReverseMap();
            CreateMap<PlaceTypeDto, PlaceType>().ReverseMap();
        }
    }
}
