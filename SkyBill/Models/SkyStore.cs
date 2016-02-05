using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBill.Models
{
    public class SkyStore
    {
        public List<Rental> rentals { get; set; }
        public List<BuyAndKeep> buyAndKeep { get; set; }
        public double total { get; set; }
    }
}