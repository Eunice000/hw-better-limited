﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBTutorial5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class classicmodelsEntities : DbContext
    {
        public classicmodelsEntities()
            : base("name=classicmodelsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<customer> customers { get; set; }
        public DbSet<employee> employees { get; set; }
        public DbSet<office> offices { get; set; }
        public DbSet<orderdetail> orderdetails { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<payment> payments { get; set; }
        public DbSet<productline> productlines { get; set; }
        public DbSet<product> products { get; set; }
    }
}