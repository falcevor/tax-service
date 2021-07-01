using MediatR;
using System.Collections.Generic;

namespace TaxService.Application.Features.Taxpayer.Queries.GetAll
{
    public class GetTaxpayersQuery : IRequest<IEnumerable<GetTaxpayersResponse>>
    {
    }
}
