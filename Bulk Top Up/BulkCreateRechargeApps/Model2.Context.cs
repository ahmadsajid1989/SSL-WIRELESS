﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BulkCreateRechargeApps
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bulktopupEntities : DbContext
    {
        public bulktopupEntities()
            : base("name=bulktopupEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<RechargeInfoTbl> RechargeInfoTbls { get; set; }
        public DbSet<api_logs> api_logs { get; set; }
        public DbSet<FailureLog> FailureLogs { get; set; }
        public DbSet<SuccessLog> SuccessLogs { get; set; }
    }
}
