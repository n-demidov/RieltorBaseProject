﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RieltorBase.Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VolgaInfoDBEntities : DbContext
    {
        public VolgaInfoDBEntities()
            : base("name=VolgaInfoDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Changelog> Changelogs { get; set; }
        public virtual DbSet<ChangelogAgent> ChangelogAgents { get; set; }
        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<Password> Passwords { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }
        public virtual DbSet<PropertyValue> PropertyValues { get; set; }
        public virtual DbSet<RealtyObject> RealtyObjects { get; set; }
        public virtual DbSet<RealtyObjectType> RealtyObjectTypes { get; set; }
    }
}
