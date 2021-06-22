using System;

namespace TaxService.Data.Model
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}
