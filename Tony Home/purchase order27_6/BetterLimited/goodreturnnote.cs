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
    
    public partial class goodreturnnote
    {
        public goodreturnnote()
        {
            this.goodreturnnote_item = new HashSet<goodreturnnote_item>();
        }
    
        public int ReturnNoteID { get; set; }
        public int SalesOrderID { get; set; }
        public int StoreID { get; set; }
        public int StaffID { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }
    
        public virtual ICollection<goodreturnnote_item> goodreturnnote_item { get; set; }
        public virtual salesorder salesorder { get; set; }
        public virtual staff staff { get; set; }
        public virtual store store { get; set; }
    }
}