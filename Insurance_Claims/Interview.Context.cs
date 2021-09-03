﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insurance_Claims
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InterviewEntities : DbContext
    {
        public InterviewEntities()
            : base("name=InterviewEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LossType> LossTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Claim> Claims { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<FileActivityLink> FileActivityLinks { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<LegacyActivity> LegacyActivities { get; set; }
        public virtual DbSet<LegacyActivityCategory> LegacyActivityCategories { get; set; }
        public virtual DbSet<LegacyActivityType> LegacyActivityTypes { get; set; }
        public virtual DbSet<PartyClaimRole> PartyClaimRoles { get; set; }
        public virtual DbSet<PartyType> PartyTypes { get; set; }
    }
}