using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.Taxpayer.Commands.Delete
{
    public class DeleteTaxpayerHandler : IRequestHandler<DeleteTaxpayerCommand>
    {
        private readonly IAsyncRepository<Domain.Model.Taxpayer>  _repo;

        public DeleteTaxpayerHandler(IAsyncRepository<Domain.Model.Taxpayer> repo)
        {
            _repo = repo;
        }

        public async Task<Unit> Handle(DeleteTaxpayerCommand request, CancellationToken cancellationToken)
        {
            await _repo.DeleteAsync(request.Id, cancellationToken);
            return await Task.FromResult(Unit.Value);
        }
    }
}
