using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Model.ViewModel
{
    public class ProductDetailModel
    {
      
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

         [Required]
        public Nullable<decimal> ProductPrice { get; set; }
        public Nullable<decimal> ProductOldPrice { get; set; }
        public Nullable<int> ProductAvailableQTY { get; set; }
        public string SplOffer { get; set; }
        public string ProductDesc { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string ProductCode { get; set; }
        [Required]
        public string ProductCategory { get; set; }

    }
}
