using MediatR;
using System.Collections.Generic;

namespace TaxService.Application.Features.ReportTemplate.Queries.GetAll
{
    public class GetReportTemplatesQuery : IRequest<IEnumerable<GetReportTemplatesResponse>>
    {
    }
}
