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
    
    public partial class salesreceipt
    {
        public int ReceiptID { get; set; }
        public int SalesOrderID { get; set; }
        public int CustomerID { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public string PaymentType { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual salesorder salesorder { get; set; }
    }
}
