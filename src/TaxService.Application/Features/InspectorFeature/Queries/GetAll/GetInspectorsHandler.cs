using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.InspectorFeature.Queries.GetAll
{
    public class GetInspectorsHandler : IRequestHandler<GetInspectorsQuery, IEnumerable<GetInspectorsResponse>>
    {
        private IAsyncRepository<Inspector> _repo;
        private IMapper _mapper;

        public GetInspectorsHandler(IAsyncRepository<Inspector> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetInspectorsResponse>> Handle(GetInspectorsQuery request, CancellationToken cancellationToken)
        {
            return _mapper.ProjectTo<GetInspectorsResponse>(await _repo.GetAllAsync(cancellationToken));
        }
    }
}
