﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoSistema.ModeloDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sistema_VentaEntities : DbContext
    {
        public Sistema_VentaEntities()
            : base("name=Sistema_VentaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetalleFacCompra> DetalleFacCompra { get; set; }
        public virtual DbSet<DetalleFacVenta> DetalleFacVenta { get; set; }
        public virtual DbSet<FacturaCompra> FacturaCompra { get; set; }
        public virtual DbSet<FacturaVenta> FacturaVenta { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<TipoEntrada> TipoEntrada { get; set; }
        public virtual DbSet<TipoSalida> TipoSalida { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
