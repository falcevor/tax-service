﻿using System;
using System.Collections.Generic;
using TaxService.Domain.Model;

namespace TaxService.Application.Features.Taxpayer.Queries.GetAll
{
    public class GetTaxpayersResponse
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
        public IEnumerable<Document> Documents { get; set; }

        public IEnumerable<Income> Incomes { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}
