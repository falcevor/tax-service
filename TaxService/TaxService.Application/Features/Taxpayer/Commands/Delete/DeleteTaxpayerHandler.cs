using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.Taxpayer.Commands.Delete
{
    public class DeleteTaxpayerHandler : IRequestHandler<DeleteTaxpayerCommand>
    {
        private readonly ITaxRepository _repo;

        public DeleteTaxpayerHandler(ITaxRepository repo)
        {
            _repo = repo;
        }

        public async Task<Unit> Handle(DeleteTaxpayerCommand request, CancellationToken cancellationToken)
        {
            
        }
    }
}
