using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.TaxpayerFeature.Commands.Create
{
    public class CreateTaxpayerHandler : IRequestHandler<CreateTaxpayerCommand>
    {
        private readonly IAsyncRepository<Taxpayer> _repo;
        private readonly IMapper _mapper;

        public CreateTaxpayerHandler(IAsyncRepository<Taxpayer> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateTaxpayerCommand request, CancellationToken cancellationToken)
        {
            var taxpayer = _mapper.Map<Taxpayer>(request);
            await _repo.CreateAsync(taxpayer, cancellationToken);
            return Unit.Value;
        }
    }
}
