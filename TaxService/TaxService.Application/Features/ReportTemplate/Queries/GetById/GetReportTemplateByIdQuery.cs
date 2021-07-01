using MediatR;

namespace TaxService.Application.Features.ReportTemplate.Queries.GetById
{
    public class GetReportTemplateByIdQuery : IRequest<GetReportTemplateByIdResponse>
    {
        public int Id { get; set; }
    }
}
