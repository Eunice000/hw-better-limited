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
    
    public partial class store
    {
        public store()
        {
            this.retailstocklevels = new HashSet<retailstocklevel>();
            this.salesorders = new HashSet<salesorder>();
        }
    
        public int StoreID { get; set; }
        public string Address { get; set; }
        public int Tel { get; set; }
        public int StaffID { get; set; }
    
        public virtual ICollection<retailstocklevel> retailstocklevels { get; set; }
        public virtual ICollection<salesorder> salesorders { get; set; }
        public virtual staff staff { get; set; }
    }
}