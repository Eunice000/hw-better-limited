//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSModule
{
    using System;
    using System.Collections.Generic;
    
    public partial class item
    {
        public item()
        {
            this.salesorder_item = new HashSet<salesorder_item>();
            this.stocklevels = new HashSet<stocklevel>();
        }
    
        public int itemId { get; set; }
        public string itemName { get; set; }
        public string itemDescr { get; set; }
        public byte[] itemImg { get; set; }
        public decimal itemPrice { get; set; }
        public string itemCat { get; set; }
    
        public virtual ICollection<salesorder_item> salesorder_item { get; set; }
        public virtual ICollection<stocklevel> stocklevels { get; set; }
    }
}