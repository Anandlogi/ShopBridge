using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Model.ViewModel
{
   public class BillingAddressDetailModel
    {
        public int BillingAddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string COUNTRY { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string TownCity { get; set; }
        public string POSTCODE { get; set; }
        public string COUNTY { get; set; }
    }
}
