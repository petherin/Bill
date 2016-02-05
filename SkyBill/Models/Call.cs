using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBill.Models
{
    public class Call
    {
        public string called { get; set; }
        public string duration { get; set; }
        public double cost { get; set; }
    }
}