﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje_Ogrenci_Akademisyen.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OgrenciSinavEntities : DbContext
    {
        public OgrenciSinavEntities()
            : base("name=OgrenciSinavEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAkademisyen> TblAkademisyen { get; set; }
        public virtual DbSet<TblBolum> TblBolum { get; set; }
        public virtual DbSet<TblDersler> TblDersler { get; set; }
        public virtual DbSet<TblNotlar> TblNotlar { get; set; }
        public virtual DbSet<TblOgrenci> TblOgrenci { get; set; }
    }
}
