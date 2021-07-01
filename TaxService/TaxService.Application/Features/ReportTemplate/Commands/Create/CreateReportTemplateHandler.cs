using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.ReportTemplate.Commands.Create
{
    public class CreateReportTemplateHandler : IRequestHandler<CreateReportTemplateCommand>
    {
        private readonly IAsyncRepository<Domain.Model.ReportTemplate> _repo;
        private readonly IMapper _mapper;

        public CreateReportTemplateHandler(IAsyncRepository<Domain.Model.ReportTemplate> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateReportTemplateCommand request, CancellationToken cancellationToken)
        {
            var template = _mapper.Map<Domain.Model.ReportTemplate>(request);
            await _repo.CreateAsync(template, cancellationToken);
            return Unit.Value;
        }
    }
}
