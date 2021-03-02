using System;
using System.Collections.Generic;

namespace SabaPayamak.Models
{
    public class MessageViewModel
    {
        public long MessageID { get; set; }
        public int UserID { get; set; }
        public string Body { get; set; }
        public string Sender { get; set; }
        public int MessagePage { get; set; }
        public double Credit { get; set; }
        public DateTime InsertDate { get; set; }
        public bool IsUnicode { get; set; }
        public int MessageCount { get; set; }
        public int Status { get; set; }
        public string StatusDesc { get; set; }
        public virtual List<DeliveryViewModel> Deliveries { get; set; }
    }
}
