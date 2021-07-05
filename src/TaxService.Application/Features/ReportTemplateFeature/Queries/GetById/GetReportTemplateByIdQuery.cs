using MediatR;

namespace TaxService.Application.Features.ReportTemplateFeature.Queries.GetById
{
    public class GetReportTemplateByIdQuery : IRequest<GetReportTemplateByIdResponse>
    {
        public int Id { get; set; }
    }
}
