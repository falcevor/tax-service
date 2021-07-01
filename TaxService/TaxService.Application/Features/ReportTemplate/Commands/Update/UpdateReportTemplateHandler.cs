using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaxService.Application.Repositories;

namespace TaxService.Application.Features.ReportTemplate.Commands.Update
{
    public class UpdateReportTemplateHandler : IRequestHandler<UpdateReportTemplateCommand>
    {
        private readonly IAsyncRepository<Domain.Model.ReportTemplate> _repo;
        private readonly IMapper _mapper;

        public UpdateReportTemplateHandler(IAsyncRepository<Domain.Model.ReportTemplate> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateReportTemplateCommand request, CancellationToken cancellationToken)
        {
            var template = _mapper.Map<Domain.Model.ReportTemplate>(request);
            await _repo.UpdateAsync(template, cancellationToken);
            return await Task.FromResult(Unit.Value);
        }
    }
}
