﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiddingMaintenance_SQL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dmBiddingEntities : DbContext
    {
        public dmBiddingEntities()
            : base("name=dmBiddingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<action> actions { get; set; }
        public virtual DbSet<balancedaction> balancedactions { get; set; }
        public virtual DbSet<bid> bids { get; set; }
        public virtual DbSet<bidbox> bidboxes { get; set; }
        public virtual DbSet<convention> conventions { get; set; }
        public virtual DbSet<fourcardmajoraction> fourcardmajoractions { get; set; }
        public virtual DbSet<losingtrickcountrange> losingtrickcountranges { get; set; }
        public virtual DbSet<ltcaction> ltcactions { get; set; }
        public virtual DbSet<opponentbidaction> opponentbidactions { get; set; }
        public virtual DbSet<partnerbidaction> partnerbidactions { get; set; }
        public virtual DbSet<pointrange> pointranges { get; set; }
        public virtual DbSet<protectiveaction> protectiveactions { get; set; }
        public virtual DbSet<referencedsuit> referencedsuits { get; set; }
        public virtual DbSet<setting> settings { get; set; }
        public virtual DbSet<shape> shapes { get; set; }
        public virtual DbSet<shapeaction> shapeactions { get; set; }
        public virtual DbSet<shapedetail> shapedetails { get; set; }
        public virtual DbSet<stage> stages { get; set; }
        public virtual DbSet<suitaction> suitactions { get; set; }
        public virtual DbSet<suitname> suitnames { get; set; }
        public virtual DbSet<suitquality> suitqualities { get; set; }
        public virtual DbSet<suitqualityaction> suitqualityactions { get; set; }
        public virtual DbSet<system> systems { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
