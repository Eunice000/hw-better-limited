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
    
    public partial class stocklevel
    {
        public int storeId { get; set; }
        public int itemId { get; set; }
        public int qty { get; set; }
    
        public virtual item item { get; set; }
        public virtual store store { get; set; }
    }
}