using MediatR;
using System.Collections.Generic;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.ReportTemplateFeature.Commands.Create
{
    public class CreateReportTemplateCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public IList<ReportTemplateParameter> Parameters { get; set; }
    }
}
