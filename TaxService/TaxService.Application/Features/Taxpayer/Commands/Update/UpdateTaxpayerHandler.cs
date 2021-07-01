using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.Taxpayer.Commands.Update
{
    public class UpdateTaxpayerHandler : IRequestHandler<UpdateTaxpayerCommand>
    {
        private IAsyncRepository<Domain.Model.Taxpayer> _repo;
        private IMapper _mapper;

        public UpdateTaxpayerHandler(IAsyncRepository<Domain.Model.Taxpayer> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTaxpayerCommand request, CancellationToken cancellationToken)
        {
            var taxpayer = _mapper.Map<Domain.Model.Taxpayer>(request);
            await _repo.UpdateAsync(taxpayer, cancellationToken);
            return Unit.Value;
        }
    }
}
