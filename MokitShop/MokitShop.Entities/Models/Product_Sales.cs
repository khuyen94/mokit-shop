//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MokitShop.Entities.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Sales
    {
        public int SaleId { get; set; }
        public int ProId { get; set; }
        public decimal SalePercent { get; set; }
        public System.DateTime DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    
        public virtual Product Product { get; set; }
    }
}