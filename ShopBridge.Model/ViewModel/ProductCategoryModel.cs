using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Model.ViewModel
{
    public class ProductCategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
