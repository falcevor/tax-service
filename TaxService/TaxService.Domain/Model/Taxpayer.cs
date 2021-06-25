using System;

namespace TaxService.Domain.Model
{
    public class Taxpayer
    {
        public int Id { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }
        public string AdditionalInfo { get; set; }
        public string PlaceAddress { get; set; }

        public int CategoryId { get; set; }
        public int TaxTypeId { get; set; }
        public int PlaceTypeId { get; set; }
        
        public TaxpayerCategory Category { get; set; }
        public TaxType TaxType { get; set; }
        public PlaceType PlaceType { get; set; }

        public DateTime BeginDate { get; set; }
        public Document[] Documents { get; set; }
    }
}
