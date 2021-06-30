using MediatR;

namespace TaxService.Application.Features.ReportTemplate.Commands.Delete
{
    public class DeleteRecordTemplateCommand : IRequest
    {
        public int Id { get; set; }
    }
}
