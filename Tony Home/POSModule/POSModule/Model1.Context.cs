﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbEntities : DbContext
    {
        public dbEntities()
            : base("name=dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<customer> customers { get; set; }
        public DbSet<deliveryorder> deliveryorders { get; set; }
        public DbSet<goodreturnnote> goodreturnnotes { get; set; }
        public DbSet<goodreturnnote_item> goodreturnnote_item { get; set; }
        public DbSet<goodsreceivednote> goodsreceivednotes { get; set; }
        public DbSet<installationorder> installationorders { get; set; }
        public DbSet<inventorystocklevel> inventorystocklevels { get; set; }
        public DbSet<item> items { get; set; }
        public DbSet<purchaseorder> purchaseorders { get; set; }
        public DbSet<purchaseorder_item> purchaseorder_item { get; set; }
        public DbSet<reorderrequest> reorderrequests { get; set; }
        public DbSet<restockrequest> restockrequests { get; set; }
        public DbSet<retailstocklevel> retailstocklevels { get; set; }
        public DbSet<salesorder> salesorders { get; set; }
        public DbSet<salesorder_item> salesorder_item { get; set; }
        public DbSet<staff> staffs { get; set; }
        public DbSet<store> stores { get; set; }
        public DbSet<supplier> suppliers { get; set; }
        public DbSet<useraccount> useraccounts { get; set; }
        public DbSet<reorderrequest_item> reorderrequest_item { get; set; }
        public DbSet<restockrequest_item> restockrequest_item { get; set; }
    }
}