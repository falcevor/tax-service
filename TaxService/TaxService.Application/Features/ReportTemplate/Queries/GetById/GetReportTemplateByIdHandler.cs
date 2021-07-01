using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.ReportTemplate.Queries.GetById
{
    public class GetReportTemplateByIdHandler : IRequestHandler<GetReportTemplateByIdQuery, GetReportTemplateByIdResponse>
    {
        private readonly IAsyncRepository<Domain.Model.ReportTemplate> _repo;
        private readonly IMapper _mapper;

        public GetReportTemplateByIdHandler(IAsyncRepository<Domain.Model.ReportTemplate> repo, IMapper mapper)
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
