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
    
    public partial class deliverynote
    {
        public int DeliveryID { get; set; }
        public int SalesOrderID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public System.TimeSpan DeliveryTime { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual salesorder salesorder { get; set; }
    }
}
