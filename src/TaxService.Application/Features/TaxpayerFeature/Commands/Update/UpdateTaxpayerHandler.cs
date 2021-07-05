using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.TaxpayerFeature.Commands.Update
{
    public class UpdateTaxpayerHandler : IRequestHandler<UpdateTaxpayerCommand>
    {
        private IAsyncRepository<Taxpayer> _repo;
        private IMapper _mapper;

        public UpdateTaxpayerHandler(IAsyncRepository<Taxpayer> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTaxpayerCommand request, CancellationToken cancellationToken)
        {
            var taxpayer = _mapper.Map<Taxpayer>(request);
            await _repo.UpdateAsync(taxpayer, cancellationToken);
            return Unit.Value;
        }
    }
}
