using System;

namespace SabaPayamak.Models
{
    public class DeliveryViewModel
    {
        public long RecordID { get; set; }
        public long MessageID { get; set; }
        public DateTime SendDate { get; set; }
        public string Number { get; set; }
        public byte DeliveryFlag { get; set; }
        public string DeliveryDesc { get; set; }
    }
}
