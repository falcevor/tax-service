using System;
using System.Collections.Generic;

namespace TaxService.Data.Model
{
    public class TaxpayerDto
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

        public TaxpayerCategoryDto Category { get; set; }
        public TaxTypeDto TaxType { get; set; }
        public PlaceTypeDto PlaceType { get; set; }

        public DateTime BeginDate { get; set; }
        public IEnumerable<DocumentDto> Documents { get; set; }

        public IEnumerable<IncomeDto> Incomes { get; set; }
        public IEnumerable<PaymentDto> Payments { get; set; }
    }
}
