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
    
    public partial class supplier
    {
        public supplier()
        {
            this.goodreturnnotes = new HashSet<goodreturnnote>();
            this.goodsreceivednotes = new HashSet<goodsreceivednote>();
            this.items = new HashSet<item>();
            this.purchaseorders = new HashSet<purchaseorder>();
        }
    
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public int Tel { get; set; }
    
        public virtual ICollection<goodreturnnote> goodreturnnotes { get; set; }
        public virtual ICollection<goodsreceivednote> goodsreceivednotes { get; set; }
        public virtual ICollection<item> items { get; set; }
        public virtual ICollection<purchaseorder> purchaseorders { get; set; }
    }
}
