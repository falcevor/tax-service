using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.Taxpayer.Queries.GetById
{
    public class GetTaxpayerByIdHandler : IRequestHandler<GetTaxpayerByIdQuery, GetTaxpayerByIdResponse>
    {
        private readonly IAsyncRepository<Domain.Model.Taxpayer> _repo;
        private readonly IMapper _mapper;

        public GetTaxpayerByIdHandler(IAsyncRepository<Domain.Model.Taxpayer> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<GetTaxpayerByIdResponse> Handle(GetTaxpayerByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetTaxpayerByIdResponse>(await _repo.GetAsync(request.Id, cancellationToken));
        }
    }
}
