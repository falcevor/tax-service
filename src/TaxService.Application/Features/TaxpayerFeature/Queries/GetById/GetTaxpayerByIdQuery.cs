using MediatR;

namespace TaxService.Application.Features.TaxpayerFeature.Queries.GetById
{
    public class GetTaxpayerByIdQuery : IRequest<GetTaxpayerByIdResponse>
    {
        public int Id { get; set; }
    }
}
