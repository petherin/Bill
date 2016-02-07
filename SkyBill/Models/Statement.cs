using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBill.Models
{
    public class Statement
    {
        public DateTime generated { get; set; }
        public DateTime due { get; set; }
        public Period period { get; set; }
    }
}