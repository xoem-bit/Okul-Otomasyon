﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Efe_1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OkulOtomasyonEntities : DbContext
    {
        public OkulOtomasyonEntities()
            : base("name=OkulOtomasyonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBL_BRANS> TBL_BRANS { get; set; }
        public virtual DbSet<tbl_il> tbl_il { get; set; }
        public virtual DbSet<tbl_ilce> tbl_ilce { get; set; }
        public virtual DbSet<TBL_OGRENCILER> TBL_OGRENCILER { get; set; }
        public virtual DbSet<TBL_OGRETMEN> TBL_OGRETMEN { get; set; }
        public virtual DbSet<TBL_VELILER> TBL_VELILER { get; set; }
        public virtual DbSet<TBL_OGRAYARLAR> TBL_OGRAYARLAR { get; set; }
    
        public virtual ObjectResult<AyarlarOgrenciler_Result> AyarlarOgrenciler()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AyarlarOgrenciler_Result>("AyarlarOgrenciler");
        }
    
        public virtual ObjectResult<AyarlarOgretmenler_Result> AyarlarOgretmenler()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AyarlarOgretmenler_Result>("AyarlarOgretmenler");
        }
    }
}
