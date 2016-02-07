using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SkyBill.Models
{
    public class SkyStore
    {
        [DisplayName("Rental")]
        public List<Rental> rentals { get; set; }
        [DisplayName("Buy and Keep")]
        public List<BuyAndKeep> buyAndKeep { get; set; }
        public double Total { get; set; }
    }
}