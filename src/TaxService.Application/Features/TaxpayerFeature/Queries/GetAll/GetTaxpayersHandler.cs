using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.TaxpayerFeature.Queries.GetAll
{
    public class GetTaxpayersHandler : IRequestHandler<GetTaxpayersQuery, IEnumerable<GetTaxpayersResponse>>
    {
        private readonly IAsyncRepository<Taxpayer> _repos;
        private readonly IMapper _mapper;

        public GetTaxpayersHandler(IAsyncRepository<Taxpayer> repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetTaxpayersResponse>> Handle(GetTaxpayersQuery request, CancellationToken cancellationToken)
        {
            return _mapper.ProjectTo<GetTaxpayersResponse>(await _repos.GetAllAsync(cancellationToken));
        }
    }
}
