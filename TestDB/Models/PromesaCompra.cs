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
    
    public partial class PromesaCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PromesaCompra()
        {
            this.OrdenDespacho = new HashSet<OrdenDespacho>();
        }
    
        public int ClavePromesaCompra { get; set; }
        public int ClaveSucursalPromesaCompra { get; set; }
        public string SeriePromesaCompra { get; set; }
        public int FolioPromesaCompra { get; set; }
        public System.Guid Cliente_Id { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public decimal Importe { get; set; }
        public int OpcEstatus { get; set; }
        public Nullable<System.Guid> NotaCredito_Id { get; set; }
        public decimal PorcentajeBonificacion { get; set; }
        public Nullable<int> UsuarioCancelo { get; set; }
        public Nullable<System.DateTime> FechaCancelo { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual NotaCredito NotaCredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDespacho> OrdenDespacho { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
