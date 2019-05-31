//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestDB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdenCompraProductoExcedente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenCompraProductoExcedente()
        {
            this.ReciboProductoDetalle = new HashSet<ReciboProductoDetalle>();
        }
    
        public Nullable<int> UsuarioAutoriza { get; set; }
        public Nullable<int> UsuarioSucursalAutoriza { get; set; }
        public Nullable<System.DateTime> FechaUsuarioAutoriza { get; set; }
        public Nullable<int> CantidadAutoriza { get; set; }
        public Nullable<int> OpcEstatus { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public System.Guid OrdenCompraProductoExcedenteId { get; set; }
        public System.Guid OrdenCompraProductoId { get; set; }
    
        public virtual OrdenCompraProducto OrdenCompraProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReciboProductoDetalle> ReciboProductoDetalle { get; set; }
    }
}
