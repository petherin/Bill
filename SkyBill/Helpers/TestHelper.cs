using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace SkyBill.Helpers
{
    public class TestHelper
    {
      public RouteCollection RouteTableData
        {
            get
            {
                RouteCollection routes = new RouteCollection();
                RouteConfig.RegisterRoutes(routes);
                return routes;
            }
        }
    }
}