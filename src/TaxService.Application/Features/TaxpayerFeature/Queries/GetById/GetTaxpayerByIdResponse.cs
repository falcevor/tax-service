using System;
using System.Collections.Generic;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.TaxpayerFeature.Queries.GetById
{
    public class GetTaxpayerByIdResponse
    {
        public int Id { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }
        public string AdditionalInfo { get; set; }
        public string PlaceAddress { get; set; }

        public TaxpayerCategory Category { get; set; }
        public TaxType TaxType { get; set; }
        public PlaceType PlaceType { get; set; }
        public Area Area { get; set; }

        public DateTime BeginDate { get; set; }
        public IList<Document> Documents { get; set; }

        public IList<Income> Incomes { get; set; }
        public IList<Payment> Payments { get; set; }
    }
}
