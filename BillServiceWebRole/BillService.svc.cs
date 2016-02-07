using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BillServiceWebRole
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class BillService : IBillService
    {
        WebClient _webClient;

        public BillService(WebClient webClient)
        {
            _webClient = webClient;
        }

        public BillService()
        {
            _webClient = new WebClient();
            _webClient.BaseAddress = "http://safe-plains-5453.herokuapp.com/";
        }

        public virtual string GetBill()
        {
            string uri = "bill.json";
            string response;

            try
            {
                response = _webClient.DownloadString(uri);
            }
            catch (WebException e)
            {
                return e.ToString();
            }
          
            return response;
        }
    }
}
