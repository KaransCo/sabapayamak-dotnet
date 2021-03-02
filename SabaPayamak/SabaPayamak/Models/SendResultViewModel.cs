using System.Collections.Generic;

namespace SabaPayamak.Models
{
    public class SendResultViewModel
    {
        public long ID { get; set; }
        public int MessageStatus { get; set; }
        public string Message { get; set; }
        public double Credit { get; set; }
        public List<SendDetailResultViewModel> Detail { get; set; }
    }
}
