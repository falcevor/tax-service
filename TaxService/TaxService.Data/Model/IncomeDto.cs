using System;

namespace TaxService.Data.Model
{
    public class IncomeDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public TaxpayerDto Taxpayer { get; set; }
    }
}
