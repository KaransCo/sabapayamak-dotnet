using System;

namespace SabaPayamak.Models
{
    public class CreditViewModel
    {
        public string CreditType { get; set; }
        public double Amount { get; set; }
        public double CreditRemain { get; set; }
        public string Descriptions { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
