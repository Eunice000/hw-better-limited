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
            this.salesorder_item = new HashSet<salesorder_item>();
        }
    
        public int salesOrderId { get; set; }
        public decimal paidAmt { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }
        public string PaymentStatus { get; set; }
    
        public virtual ICollection<salesorder_item> salesorder_item { get; set; }
    }
}
