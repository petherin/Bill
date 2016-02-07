using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBill.Models
{
    public class Bill
    {
        public Statement statement { get; set; }
        public double Total { get; set; }
        public Package package { get; set; }
        public CallCharges callCharges { get; set; }
        public SkyStore skyStore { get; set; }
    }
}