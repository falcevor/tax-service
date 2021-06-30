using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.ReportTemplate.Commands.Delete
{
    public class DeleteRecordTemplateHandler : IRequestHandler<DeleteRecordTemplateCommand>
    {
        private readonly IAsyncRepository<Domain.Model.ReportTemplate> _repo;

        public DeleteRecordTemplateHandler(IAsyncRepository<Domain.Model.ReportTemplate> repo)
        {
            _repo = repo;
        }

        public async Task<Unit> Handle(DeleteRecordTemplateCommand request, CancellationToken cancellationToken)
        {
            await _repo.DeleteAsync(request.Id, cancellationToken);
            return await Task.FromResult(Unit.Value);
        }
    }
}
