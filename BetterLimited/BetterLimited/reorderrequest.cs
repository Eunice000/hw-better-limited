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
    
    public partial class reorderrequest
    {
        public reorderrequest()
        {
            this.reorderrequest_item = new HashSet<reorderrequest_item>();
        }
    
        public int ReorderRequestID { get; set; }
        public int StaffID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public System.TimeSpan RequestTime { get; set; }
        public string RequestStatus { get; set; }
    
        public virtual ICollection<reorderrequest_item> reorderrequest_item { get; set; }
        public virtual staff staff { get; set; }
    }
}
