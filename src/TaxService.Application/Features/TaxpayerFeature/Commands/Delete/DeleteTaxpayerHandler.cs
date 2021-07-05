using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.TaxpayerFeature.Commands.Delete
{
    public class DeleteTaxpayerHandler : IRequestHandler<DeleteTaxpayerCommand>
    {
        private readonly IAsyncRepository<Taxpayer>  _repo;

        public DeleteTaxpayerHandler(IAsyncRepository<Taxpayer> repo)
        {
            _repo = repo;
        }

        public async Task<Unit> Handle(DeleteTaxpayerCommand request, CancellationToken cancellationToken)
        {
            await _repo.DeleteAsync(request.Id, cancellationToken);
            return Unit.Value;
        }
    }
}
