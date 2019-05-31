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
    
    public partial class DespachoMesaSucursal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DespachoMesaSucursal()
        {
            this.OrdenDespacho = new HashSet<OrdenDespacho>();
        }
    
        public int ClaveDespachoMesaSucursalSucursal { get; set; }
        public int ClaveDespachoMesaSucursal { get; set; }
        public short ClaveTipoPrioridad { get; set; }
        public short ClaveTipoMesa { get; set; }
        public Nullable<bool> Asignado { get; set; }
        public Nullable<bool> Disponible { get; set; }
        public System.DateTime Asignacion { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Sucursal Sucursal { get; set; }
        public virtual TipoMesa TipoMesa { get; set; }
        public virtual TipoPrioridad TipoPrioridad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDespacho> OrdenDespacho { get; set; }
    }
}
