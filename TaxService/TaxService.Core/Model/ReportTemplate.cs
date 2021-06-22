﻿namespace TaxService.Core.Model
{
    public class ReportTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public ReportTemplateParameter[] Parameters { get; set; }
    }
}
