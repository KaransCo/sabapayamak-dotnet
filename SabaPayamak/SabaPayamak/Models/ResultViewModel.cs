using SabaPayamak.Enum;
using System.Collections.Generic;

namespace SabaPayamak.Models
{
    public class ResultViewModel
    {
        public HttpStatus status { get; set; }
        public string message { get; set; }
        public string id { get; set; }
        public object data { get; set; }
        public List<Errors> errors { get; set; }

    }

    public class Errors
    {
        public string message { get; set; }
        public string url { get; set; }
        public int code { get; set; }
        public string field { get; set; }
    }

   
}
