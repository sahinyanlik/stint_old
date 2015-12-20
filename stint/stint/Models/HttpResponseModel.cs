using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace stint.Models
{
     class HttpResponseModel
    {
        public int code { get; set; }
        public bool succeeded { get; set; }
        public string message { get; set; }
        public JObject objects { get; set; } 
            
    }
}
