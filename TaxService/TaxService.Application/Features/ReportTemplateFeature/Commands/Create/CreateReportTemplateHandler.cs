using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.ReportTemplateFeature.Commands.Create
{
    public class CreateReportTemplateHandler : IRequestHandler<CreateReportTemplateCommand>
    {
        private readonly IAsyncRepository<ReportTemplate> _repo;
        private readonly IMapper _mapper;

        public CreateReportTemplateHandler(IAsyncRepository<ReportTemplate> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateReportTemplateCommand request, CancellationToken cancellationToken)
        {
            var template = _mapper.Map<ReportTemplate>(request);
            await _repo.CreateAsync(template, cancellationToken);
            return Unit.Value;
        }
    }
}
