using System;

namespace TaxService.Core.Model
{
    public class Taxpayer
    {
        public int Id { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string TaxType { get; set; }
        public int Percent { get; set; }
        public string PlaceType { get; set; }
        public string PlaceAddress { get; set; }
        public DateTime BeginDate { get; set; }
        public string AdditionalInfo { get; set; }
        public Document[] Documents { get; set; }
    }
}
