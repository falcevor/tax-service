using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.ReportTemplateFeature.Queries.GetById
{
    public class GetReportTemplateByIdHandler : IRequestHandler<GetReportTemplateByIdQuery, GetReportTemplateByIdResponse>
    {
        private readonly IAsyncRepository<ReportTemplate> _repo;
        private readonly IMapper _mapper;

        public GetReportTemplateByIdHandler(IAsyncRepository<ReportTemplate> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<GetReportTemplateByIdResponse> Handle(GetReportTemplateByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetReportTemplateByIdResponse>(await _repo.GetAsync(request.Id, cancellationToken));
            
        }
    }
}
