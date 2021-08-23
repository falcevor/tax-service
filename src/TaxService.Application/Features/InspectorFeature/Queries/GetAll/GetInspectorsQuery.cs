using MediatR;
using System.Collections.Generic;

namespace TaxService.Application.Features.InspectorFeature.Queries.GetAll
{
    public class GetInspectorsQuery : IRequest<IEnumerable<GetInspectorsResponse>>
    {
    }
}
