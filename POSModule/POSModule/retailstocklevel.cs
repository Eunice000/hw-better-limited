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
    
    public partial class retailstocklevel
    {
        public int itemID { get; set; }
        public int StoreID { get; set; }
        public int Quantity { get; set; }
        public int LowLevelQty { get; set; }
    
        public virtual item item { get; set; }
        public virtual store store { get; set; }
    }
}
