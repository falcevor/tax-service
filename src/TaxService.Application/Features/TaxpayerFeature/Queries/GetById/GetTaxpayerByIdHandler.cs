using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.TaxpayerFeature.Queries.GetById
{
    public class GetTaxpayerByIdHandler : IRequestHandler<GetTaxpayerByIdQuery, GetTaxpayerByIdResponse>
    {
        private readonly IAsyncRepository<Taxpayer> _repo;
        private readonly IMapper _mapper;

        public GetTaxpayerByIdHandler(IAsyncRepository<Taxpayer> repo, IMapper mapper)
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
