using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BillServiceWebRole
{
    [ServiceContract]
    public interface IBillService
    {
        [OperationContract]
        string GetBill();
    }
}
