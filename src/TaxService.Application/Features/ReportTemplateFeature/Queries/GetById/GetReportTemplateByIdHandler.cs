using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Exceptions;
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
            var result = await _repo.GetAsync(request.Id, cancellationToken);
            if (result is null) throw new NotFoundException($"There is no such Report Template with id={request.Id}");
            return _mapper.Map<GetReportTemplateByIdResponse>(result);

        }
    }
}
