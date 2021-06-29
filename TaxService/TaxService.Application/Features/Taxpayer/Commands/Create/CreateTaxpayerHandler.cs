using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.Taxpayer.Commands.Create
{
    public class CreateTaxpayerHandler : IRequestHandler<CreateTaxpayerCommand, int>
    {
        private readonly IAsyncRepository<Domain.Model.Taxpayer> _repo;
        private readonly IMapper _mapper;

        public CreateTaxpayerHandler(IAsyncRepository<Domain.Model.Taxpayer> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateTaxpayerCommand request, CancellationToken cancellationToken)
        {
            var taxpayer = _mapper.Map<Domain.Model.Taxpayer>(request);
            return await _repo.CreateAsync(taxpayer, cancellationToken);
        }
    }
}
