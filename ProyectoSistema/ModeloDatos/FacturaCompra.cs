//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class FacturaCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacturaCompra()
        {
            this.DetalleFacCompra = new HashSet<DetalleFacCompra>();
        }
    
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal MontoTotal { get; set; }
        public Nullable<System.DateTime> FechaCompra { get; set; }
        public int ProveedorId { get; set; }
        public int UsuarioId { get; set; }
        public int TipoEntradaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFacCompra> DetalleFacCompra { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual TipoEntrada TipoEntrada { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
