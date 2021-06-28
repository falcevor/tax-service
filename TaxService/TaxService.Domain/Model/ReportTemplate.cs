﻿using System.Collections.Generic;

namespace TaxService.Domain.Model
{
    public class ReportTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public IEnumerable<ReportTemplateParameter> Parameters { get; set; }
    }
}
