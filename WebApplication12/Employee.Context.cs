﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication12
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class testdbEntities : DbContext
    {
        public testdbEntities()
            : base("name=testdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
    
        public virtual int usp_FetchEmployeecount(ObjectParameter count)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_FetchEmployeecount", count);
        }
    
        public virtual int usp_GetEmployeeCount(ObjectParameter count)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetEmployeeCount", count);
        }
    }
}
