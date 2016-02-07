using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBill.Models
{
    public class CallCharges
    {
        public List<Call> calls { get; set; }
        public double Total { get; set; }
    }
}