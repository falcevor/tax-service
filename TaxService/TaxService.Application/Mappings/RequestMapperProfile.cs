using AutoMapper;
using TaxService.Application.Features.Taxpayer.Commands.Create;
using TaxService.Application.Features.Taxpayer.Commands.Update;
using TaxService.Application.Features.Taxpayer.Queries.GetById;
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
