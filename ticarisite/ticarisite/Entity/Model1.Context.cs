﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ticarisite.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ticarisiteEntities2 : DbContext
    {
        public ticarisiteEntities2()
            : base("name=ticarisiteEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_kategori> tbl_kategori { get; set; }
        public virtual DbSet<tbl_musteri> tbl_musteri { get; set; }
        public virtual DbSet<tbl_personel> tbl_personel { get; set; }
        public virtual DbSet<tbl_satis> tbl_satis { get; set; }
        public virtual DbSet<tbl_urunler> tbl_urunler { get; set; }
        public virtual DbSet<tbl_admin> tbl_admin { get; set; }
    }
}
