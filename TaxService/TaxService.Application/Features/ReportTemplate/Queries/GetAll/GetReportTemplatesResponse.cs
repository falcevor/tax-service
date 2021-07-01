using System.Collections.Generic;

namespace TaxService.Application.Features.ReportTemplate.Queries.GetAll
{
    public class GetReportTemplatesResponse
    {
        public IEnumerable<Domain.Model.ReportTemplate> Data { get; set; }
    }
}
