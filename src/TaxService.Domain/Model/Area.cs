using System.Collections.Generic;

namespace TaxService.Domain.Model
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InspectorId { get; set; }
        public Inspector Inspector { get; set; }
        public IList<Taxpayer> Taxpayers { get; set; }
    }
}
