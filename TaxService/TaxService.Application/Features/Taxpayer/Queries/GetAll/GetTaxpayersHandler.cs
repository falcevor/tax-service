using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.Taxpayer.Queries.GetAll
{
    public class GetTaxpayersHandler : IRequestHandler<GetTaxpayersQuery, IEnumerable<GetTaxpayersResponse>>
    {
        private readonly IAsyncRepository<Domain.Model.Taxpayer> _repos;
        private readonly IMapper _mapper;

        public GetTaxpayersHandler(IAsyncRepository<Domain.Model.Taxpayer> repos, IMapper mapper)
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
