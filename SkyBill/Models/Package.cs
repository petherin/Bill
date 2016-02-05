using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBill.Models
{
    public class Package
    {
        public List<Subscription> subscriptions { get; set; }
        public double total { get; set; }
    }
}