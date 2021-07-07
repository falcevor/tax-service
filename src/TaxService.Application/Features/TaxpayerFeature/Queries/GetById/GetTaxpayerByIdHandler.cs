using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Exceptions;
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
            var result = await _repo.GetAsync(request.Id, cancellationToken);
            if (result is null) throw new NotFoundException($"There is no such Taxpayer with id={request.Id}");
            return _mapper.Map<GetTaxpayerByIdResponse>(result);
        }
    }
}
