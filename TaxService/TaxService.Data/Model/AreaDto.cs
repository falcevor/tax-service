namespace TaxService.Data.Model
{
    public class AreaDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public InspectorDto Inspector { get; set; }
    }
}
