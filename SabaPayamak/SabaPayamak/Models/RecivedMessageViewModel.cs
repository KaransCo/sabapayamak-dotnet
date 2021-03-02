using System;

namespace SabaPayamak.Models
{
    public class RecivedMessageViewModel
    {
        public string Body { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public int MessageCount { get; set; }
        public DateTime InsertDate { get; set; }
        public bool IsRead { get; set; }
    }
}
