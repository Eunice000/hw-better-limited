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
    
    public partial class restockrequest_item
    {
        public int RestockRequestID { get; set; }
        public int itemID { get; set; }
        public int Quantity { get; set; }
    
        public virtual item item { get; set; }
    }
}
