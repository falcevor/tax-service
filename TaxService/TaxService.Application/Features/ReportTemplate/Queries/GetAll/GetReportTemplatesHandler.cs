using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.ReportTemplate.Queries.GetAll
{
    public class GetReportTemplatesHandler : IRequestHandler<GetReportTemplatesQuery, GetReportTemplatesResponse>
    {
        private readonly IAsyncRepository<Domain.Model.ReportTemplate> _repo;

        public GetReportTemplatesHandler(IAsyncRepository<Domain.Model.ReportTemplate> repo)
        {
            _repo = repo;
        }

        public async Task<GetReportTemplatesResponse> Handle(GetReportTemplatesQuery request, CancellationToken cancellationToken)
        {
            var result = await _repo.GetAllAsync(cancellationToken);
            return new GetReportTemplatesResponse() { Data = result };
        }
    }
}
