using MediatR;

namespace TaxService.Application.Features.Taxpayer.Queries.GetById
{
    public class GetTaxpayerByIdQuery : IRequest<GetTaxpayerByIdResponse>
    {
        public int Id { get; set; }
    }
}
