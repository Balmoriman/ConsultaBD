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
    
    public partial class OrdenCorte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenCorte()
        {
            this.ValeInterAlmacenProducto = new HashSet<ValeInterAlmacenProducto>();
        }
    
        public System.Guid OrdenCorte_ID { get; set; }
        public Nullable<System.Guid> OrdenDespachoProductoId { get; set; }
        public Nullable<int> ClaveOrdenDespachoPartida { get; set; }
        public Nullable<int> ClaveOrdenDespacho { get; set; }
        public Nullable<int> ClaveOrdenDespachoSucursal { get; set; }
        public string Serie { get; set; }
        public Nullable<int> Folio { get; set; }
        public int ClaveTipoDocumento { get; set; }
        public int ClaveOrdenCorte { get; set; }
        public System.Guid IdentificadorCorte_ID { get; set; }
        public int CantidadSolicitada { get; set; }
        public string Comentario { get; set; }
        public int OpcEstatusOrdenCorte { get; set; }
        public Nullable<int> ClaveTipoDocumentoOrigen { get; set; }
        public Nullable<int> ClaveSucursalDocumentoOrigen { get; set; }
        public Nullable<int> ClaveDocumentoOrigen { get; set; }
        public Nullable<int> ClaveNuevoIdentificadorCorte { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual OrdenDespachoProducto OrdenDespachoProducto { get; set; }
        public virtual ProductoIdentificadorCorte ProductoIdentificadorCorte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValeInterAlmacenProducto> ValeInterAlmacenProducto { get; set; }
    }
}
