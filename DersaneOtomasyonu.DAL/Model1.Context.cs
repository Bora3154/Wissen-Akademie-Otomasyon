﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DersaneOtomasyonu.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DersaneOtomasyonuEntities1 : DbContext
    {
        public DersaneOtomasyonuEntities1()
            : base("name=DersaneOtomasyonuEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Branslar> Branslar { get; set; }
        public virtual DbSet<HaftalikOdevler> HaftalikOdevler { get; set; }
        public virtual DbSet<OdemeVadeleri> OdemeVadeleri { get; set; }
        public virtual DbSet<OgrenciKayit> OgrenciKayit { get; set; }
        public virtual DbSet<OgretmenKayit> OgretmenKayit { get; set; }
        public virtual DbSet<Siniflarr> Siniflarr { get; set; }
        public virtual DbSet<VeliKayit> VeliKayit { get; set; }
    }
}
