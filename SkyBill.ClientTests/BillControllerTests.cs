using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcRouteTester;
using SkyBill.Controllers;
using SkyBill.Helpers;
using SkyBill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace SkyBill.Controllers.Tests
{
    [TestClass()]
    public class BillControllerTests
    {

        [TestMethod]
        public async Task Details_NormalCall_ModelPopulated()
        {
            //Arrange
            BillController billController = new BillController();

            //Act
            ViewResult result = await billController.Details() as ViewResult;
            Bill bill = (Bill)result.Model;

            //Assert
            Assert.IsNotNull(bill);
        }

        [TestMethod]
        public void Default_Route_ExpectedRoutess()
        {
            // Arrange
            TestHelper helper = new TestHelper();
            RouteCollection routes = helper.RouteTableData;

            //Act/Assert
            RouteAssert.HasRoute(routes, "~/Bill/Details/");
        }

    }


}