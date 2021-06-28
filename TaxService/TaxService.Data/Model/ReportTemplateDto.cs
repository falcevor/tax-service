using System.Collections.Generic;

namespace TaxService.Data.Model
{
    public class ReportTemplateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public IEnumerable<ReportTemplateParameterDto> Parameters { get; set; }
    }
}
