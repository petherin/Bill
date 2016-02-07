using Newtonsoft.Json;
using SkyBill.Models;
using SkyBill.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SkyBill.Controllers
{
    public class BillController : Controller
    {
        // GET: Bill
        public async Task<ActionResult> Details()
        {
            Bill model = new Bill();
            BillServiceClient billClient = new BillServiceClient();

            billClient.Open();
            string response = await billClient.GetBillAsync();

            if (response == string.Empty || response.Contains("Exception"))
            {
                throw new Exception();
            }

            try
            {
                model = JsonConvert.DeserializeObject<Bill>(response);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                billClient.Close();
            }

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
            System.Threading.Thread.CurrentThread.CurrentUICulture  = new System.Globalization.CultureInfo("en-GB");

            return View(model);
        } 
    }
}
