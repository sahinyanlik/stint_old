using System;
using System.Collections.Generic;
using System.Text;

namespace stint.Models
{
    class Job : BaseAuthRequest
    {
        public string JobPosition { get; set; }
        public int JobRequired { get; set; }
        public string JobDescription { get; set; }
        public string JobLocation { get; set; }
        public string JobArea { get; set; }
        public DateTime JobDate { get; set; }
        public int JobTimeFrom { get; set; }
        public int JobTimeTo { get; set; }
        public string JobDressCode { get; set; }
        public double JobPay { get; set; }
        public int PayType { get; set; }
        public string Photo1 { get; set; }
        public int Photo1Type { get; set; }
        public string Photo2 { get; set; }
        public int Photo2Type { get; set; }
        public string Photo3 { get; set; }
        public int Photo3Type { get; set; }
        public string Photo4 { get; set; }
        public int Photo4Type { get; set; }
        
    }
}
