using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.ReportTemplate.Commands.Delete
{
    public class DeleteReportTemplateHandler : IRequestHandler<DeleteReportTemplateCommand>
    {
        private readonly IAsyncRepository<Domain.Model.ReportTemplate> _repo;

        public DeleteReportTemplateHandler(IAsyncRepository<Domain.Model.ReportTemplate> repo)
        {
            _repo = repo;
        }

        public async Task<Unit> Handle(DeleteReportTemplateCommand request, CancellationToken cancellationToken)
        {
            await _repo.DeleteAsync(request.Id, cancellationToken);
            return Unit.Value;
        }
    }
}
