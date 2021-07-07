using MediatR;
using System.Collections.Generic;

namespace TaxService.Application.Features.ReportTemplateFeature.Queries.GetAll
{
    public class GetReportTemplatesQuery : IRequest<IEnumerable<GetReportTemplatesResponse>>
    {
    }
}
