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
    
    public partial class salesorder
    {
        public salesorder()
        {
            this.deliveryorders = new HashSet<deliveryorder>();
            this.goodreturnnotes = new HashSet<goodreturnnote>();
            this.installationorders = new HashSet<installationorder>();
            this.salesorder_item = new HashSet<salesorder_item>();
        }
    
        public int SalesOrderID { get; set; }
        public int StoreID { get; set; }
        public int StaffID { get; set; }
        public string PaymentStatus { get; set; }
        public int PaidAmt { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }
        public Nullable<System.DateTime> ExpDate { get; set; }
        public Nullable<int> CustomerID { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual ICollection<deliveryorder> deliveryorders { get; set; }
        public virtual ICollection<goodreturnnote> goodreturnnotes { get; set; }
        public virtual ICollection<installationorder> installationorders { get; set; }
        public virtual staff staff { get; set; }
        public virtual store store { get; set; }
        public virtual ICollection<salesorder_item> salesorder_item { get; set; }
    }
}
