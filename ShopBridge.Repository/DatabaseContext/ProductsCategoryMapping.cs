//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopBridge.Repository.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductsCategoryMapping
    {
        public int MappingId { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
