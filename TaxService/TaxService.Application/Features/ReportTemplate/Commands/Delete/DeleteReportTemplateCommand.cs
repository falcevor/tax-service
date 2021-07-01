using MediatR;

namespace TaxService.Application.Features.ReportTemplate.Commands.Delete
{
    public class DeleteReportTemplateCommand : IRequest
    {
        public int Id { get; set; }
    }
}
