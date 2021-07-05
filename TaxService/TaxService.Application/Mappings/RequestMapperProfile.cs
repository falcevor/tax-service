using AutoMapper;
using TaxService.Application.Features.TaxpayerFeature.Commands.Create;
using TaxService.Application.Features.TaxpayerFeature.Commands.Update;
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
        }
    }
}
