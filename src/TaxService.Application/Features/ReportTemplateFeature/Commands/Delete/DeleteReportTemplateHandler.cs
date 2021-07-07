using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.ReportTemplateFeature.Commands.Delete
{
    public class DeleteReportTemplateHandler : IRequestHandler<DeleteReportTemplateCommand>
    {
        private readonly IAsyncRepository<ReportTemplate> _repo;

        public DeleteReportTemplateHandler(IAsyncRepository<ReportTemplate> repo)
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
