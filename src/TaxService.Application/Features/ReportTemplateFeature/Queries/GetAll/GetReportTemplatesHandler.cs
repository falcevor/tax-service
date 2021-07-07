using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.ReportTemplateFeature.Queries.GetAll
{
    public class GetReportTemplatesHandler : IRequestHandler<GetReportTemplatesQuery, IEnumerable<GetReportTemplatesResponse>>
    {
        private readonly IAsyncRepository<ReportTemplate> _repo;
        private readonly IMapper _mapper;

        public GetReportTemplatesHandler(IAsyncRepository<ReportTemplate> repo, IMapper mapper)
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
