﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GymDBEntities : DbContext
    {
        public GymDBEntities()
            : base("name=GymDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClosedGroupes> ClosedGroupes { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<FitnessLessons> FitnessLessons { get; set; }
        public virtual DbSet<FitnessTrainers> FitnessTrainers { get; set; }
        public virtual DbSet<Presence> Presence { get; set; }
        public virtual DbSet<SubscriptionsTypes> SubscriptionsTypes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<SystemMessege> SystemMessege { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<Purchases> Purchases { get; set; }
    }
}
