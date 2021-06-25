using System;

namespace TaxService.Domain.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public int TaxpayerId { get; set; }
        public Taxpayer Taxpayer { get; set; }
    }
}
