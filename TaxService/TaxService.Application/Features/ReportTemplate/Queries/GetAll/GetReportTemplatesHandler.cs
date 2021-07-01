using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.ReportTemplate.Queries.GetAll
{
    public class GetReportTemplatesHandler : IRequestHandler<GetReportTemplatesQuery, IEnumerable<GetReportTemplatesResponse>>
    {
        private readonly IAsyncRepository<Domain.Model.ReportTemplate> _repo;
        private readonly IMapper _mapper;

        public GetReportTemplatesHandler(IAsyncRepository<Domain.Model.ReportTemplate> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetReportTemplatesResponse>> Handle(GetReportTemplatesQuery request, CancellationToken cancellationToken)
        {
            var result = _mapper.ProjectTo<GetReportTemplatesResponse>(await _repo.GetAllAsync(cancellationToken));
            return result;
        }
    }
}
