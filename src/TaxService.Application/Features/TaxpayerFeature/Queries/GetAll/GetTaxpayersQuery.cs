using MediatR;
using System.Collections.Generic;

namespace TaxService.Application.Features.TaxpayerFeature.Queries.GetAll
{
    public class GetTaxpayersQuery : IRequest<IEnumerable<GetTaxpayersResponse>>
    {
    }
}
