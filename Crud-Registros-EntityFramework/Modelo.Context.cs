﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crud_Registros_EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntidadesVentas : DbContext
    {
        public EntidadesVentas()
            : base("name=EntidadesVentas")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
    }
}
