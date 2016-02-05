using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBill.Models
{
    public class Statement
    {
        public string generated { get; set; }
        public string due { get; set; }
        public Period period { get; set; }
    }
}