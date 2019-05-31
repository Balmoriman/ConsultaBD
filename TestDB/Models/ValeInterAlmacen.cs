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
    
    public partial class ValeInterAlmacen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ValeInterAlmacen()
        {
            this.ValeInterAlmacenProducto = new HashSet<ValeInterAlmacenProducto>();
            this.FacturaClienteCFD = new HashSet<FacturaClienteCFD>();
        }
    
        public string Serie { get; set; }
        public int Folio { get; set; }
        public int ClaveSucursalOrigen { get; set; }
        public int ClaveSucursalDestino { get; set; }
        public int OpcEstatusValeInterAlmacen { get; set; }
        public int ClaveSucursalAlmacenOrigen { get; set; }
        public int ClaveSucursalAlmacenDestino { get; set; }
        public bool ValeAutomatico { get; set; }
        public string MensajeOrigen { get; set; }
        public string MensajeDestino { get; set; }
        public Nullable<int> UsuarioAcepta { get; set; }
        public Nullable<int> UsuarioDespacho { get; set; }
        public Nullable<int> UsuarioRecibe { get; set; }
        public System.DateTime FechaSolicita { get; set; }
        public Nullable<System.DateTime> FechaAcepta { get; set; }
        public Nullable<System.DateTime> FechaDespacho { get; set; }
        public Nullable<System.DateTime> FechaRecibe { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> UsuarioCancela { get; set; }
        public Nullable<System.DateTime> FechaCancela { get; set; }
        public string CodigoIngreso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValeInterAlmacenProducto> ValeInterAlmacenProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaClienteCFD> FacturaClienteCFD { get; set; }
    }
}