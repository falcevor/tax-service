using MediatR;

namespace TaxService.Application.Features.ReportTemplateFeature.Commands.Delete
{
    public class DeleteReportTemplateCommand : IRequest
    {
        public int Id { get; set; }
    }
}
