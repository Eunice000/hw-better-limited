//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterLimited
{
    using System;
    using System.Collections.Generic;
    
    public partial class item
    {
        public item()
        {
            this.goodreturnnote_item = new HashSet<goodreturnnote_item>();
            this.retailstocklevels = new HashSet<retailstocklevel>();
            this.purchaseorder_item = new HashSet<purchaseorder_item>();
            this.salesorder_item = new HashSet<salesorder_item>();
            this.restockrequest_item = new HashSet<restockrequest_item>();
        }
    
        public int ItemID { get; set; }
        public string ItemCat { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public byte[] ItemImg { get; set; }
        public int SalePrice { get; set; }
        public int SupplierID { get; set; }
        public int SupplierPrice { get; set; }
        public int WarrantyMonth { get; set; }
        public string AllowDelivery { get; set; }
    
        public virtual ICollection<goodreturnnote_item> goodreturnnote_item { get; set; }
        public virtual inventorystocklevel inventorystocklevel { get; set; }
        public virtual ICollection<retailstocklevel> retailstocklevels { get; set; }
        public virtual supplier supplier { get; set; }
        public virtual ICollection<purchaseorder_item> purchaseorder_item { get; set; }
        public virtual ICollection<salesorder_item> salesorder_item { get; set; }
        public virtual ICollection<restockrequest_item> restockrequest_item { get; set; }
    }
}
