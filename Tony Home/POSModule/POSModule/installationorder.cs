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
    
    public partial class installationorder
    {
        public int InstallationID { get; set; }
        public int SalesOrderID { get; set; }
        public System.DateTime InstallationDate { get; set; }
        public System.TimeSpan InstallationTime { get; set; }
        public string InstallationStatus { get; set; }
    
        public virtual salesorder salesorder { get; set; }
    }
}
