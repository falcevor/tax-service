﻿using System;

namespace TaxService.Core.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}