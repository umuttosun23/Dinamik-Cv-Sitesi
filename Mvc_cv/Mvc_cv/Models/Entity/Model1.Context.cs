﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc_cv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbcvEntities4 : DbContext
    {
        public DbcvEntities4()
            : base("name=DbcvEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
        public virtual DbSet<Tbl_Deneyimlerim> Tbl_Deneyimlerim { get; set; }
        public virtual DbSet<Tbl_Egitimlerim> Tbl_Egitimlerim { get; set; }
        public virtual DbSet<Tbl_Hakkımda> Tbl_Hakkımda { get; set; }
        public virtual DbSet<Tbl_Hobilerim> Tbl_Hobilerim { get; set; }
        public virtual DbSet<Tbl_iletisim> Tbl_iletisim { get; set; }
        public virtual DbSet<Tbl_Sertifikalarım> Tbl_Sertifikalarım { get; set; }
        public virtual DbSet<Tbl_Yeteneklerim> Tbl_Yeteneklerim { get; set; }
        public virtual DbSet<Tbl_Sosyalmedya> Tbl_Sosyalmedya { get; set; }
    }
}
