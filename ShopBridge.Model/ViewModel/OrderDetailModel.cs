using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Model.ViewModel
{
   public class OrderDetailModel
    {
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public string OrderStatus { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string OrderBy { get; set; }
        public Nullable<int> BillingAddressId { get; set; }
    }
}
