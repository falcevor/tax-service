using MediatR;
using System.Collections.Generic;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.ReportTemplate.Commands.Create
{
    public class CreateReportTemplateCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public IEnumerable<ReportTemplateParameter> Parameters { get; set; }
    }
}
