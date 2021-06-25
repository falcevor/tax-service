namespace TaxService.Domain.Model
{
    public class Area
    {
        public int Id { get; set; }
        public int InspectorId { get; set; }
        public Inspector Inspector { get; set; } 
    }
}
