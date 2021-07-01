using MediatR;

namespace TaxService.Application.Features.Taxpayer.Queries.GetAll
{
    public class GetTaxpayersQuery : IRequest<GetTaxpayersResponse>
    {
    }
}
