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
    
    public partial class OrderedItemDetail
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
    
        public virtual OrderDetail OrderDetail { get; set; }
        public virtual OrderDetail OrderDetail1 { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
        public virtual ProductDetail ProductDetail1 { get; set; }
    }
}
