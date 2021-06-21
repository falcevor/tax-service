namespace TaxServiceLibrary.Model
{
    public class ReportTemplateInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public ReportTemplateParameterInfo[] Parameters { get; set; }
    }
}
