using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.ReportTemplateFeature.Commands.Update
{
    public class UpdateReportTemplateHandler : IRequestHandler<UpdateReportTemplateCommand>
    {
        private readonly IAsyncRepository<ReportTemplate> _repo;
        private readonly IMapper _mapper;

        public UpdateReportTemplateHandler(IAsyncRepository<ReportTemplate> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateReportTemplateCommand request, CancellationToken cancellationToken)
        {
            var template = _mapper.Map<ReportTemplate>(request);
            await _repo.UpdateAsync(template, cancellationToken);
            return Unit.Value;
        }
    }
}
