﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hipica.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HipicaEntities : DbContext
    {
        public HipicaEntities()
            : base("name=HipicaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Caballo> Caballo { get; set; }
        public virtual DbSet<Monitor> Monitor { get; set; }
        public virtual DbSet<Nivel> Nivel { get; set; }
        public virtual DbSet<Ruta> Ruta { get; set; }
    }
}
