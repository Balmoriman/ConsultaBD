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
    
    public partial class ProveedorAcreedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProveedorAcreedor()
        {
            this.CuentaBancariaDSA = new HashSet<CuentaBancariaDSA>();
            this.CuentaXPagar = new HashSet<CuentaXPagar>();
            this.MovimientoCuentaxPagar = new HashSet<MovimientoCuentaxPagar>();
            this.PagoCuentaxPagar = new HashSet<PagoCuentaxPagar>();
            this.ProveedorAcreedorBanco = new HashSet<ProveedorAcreedorBanco>();
            this.ProveedorAcreedorContacto = new HashSet<ProveedorAcreedorContacto>();
            this.ProveedorAcreedorDireccion = new HashSet<ProveedorAcreedorDireccion>();
            this.ProveedorAcreedorDocumento = new HashSet<ProveedorAcreedorDocumento>();
            this.SolicitudAnticipoProveedorAcreedor = new HashSet<SolicitudAnticipoProveedorAcreedor>();
            this.SolicitudEgreso = new HashSet<SolicitudEgreso>();
            this.SucursalProductoExhibicion = new HashSet<SucursalProductoExhibicion>();
        }
    
        public System.Guid ProveedorAcreedor_Id { get; set; }
        public int ClaveTipoProveedor { get; set; }
        public int ClaveProveedor { get; set; }
        public int ClaveTipoPersonalidadFiscal { get; set; }
        public int ClaveSucursal { get; set; }
        public string LiteralesRFC { get; set; }
        public string NumeralesRFC { get; set; }
        public string HomoclaveRFC { get; set; }
        public string RFC { get; set; }
        public string Nombre_1 { get; set; }
        public string Nombre_2 { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombreLargo { get; set; }
        public string CorreoAvisoPago { get; set; }
        public Nullable<System.Guid> ProveedorAcreedorDireccionFiscal_Id { get; set; }
        public Nullable<System.Guid> ProveedorDireccionContacto_Id { get; set; }
        public int DocumentosRevision { get; set; }
        public int Estatus { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaBancariaDSA> CuentaBancariaDSA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaXPagar> CuentaXPagar { get; set; }
        public virtual Direccion Direccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimientoCuentaxPagar> MovimientoCuentaxPagar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoCuentaxPagar> PagoCuentaxPagar { get; set; }
        public virtual TipoProveedor TipoProveedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProveedorAcreedorBanco> ProveedorAcreedorBanco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProveedorAcreedorContacto> ProveedorAcreedorContacto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProveedorAcreedorDireccion> ProveedorAcreedorDireccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProveedorAcreedorDocumento> ProveedorAcreedorDocumento { get; set; }
        public virtual ProveedorAcreedorDescuentos ProveedorAcreedorDescuentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitudAnticipoProveedorAcreedor> SolicitudAnticipoProveedorAcreedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitudEgreso> SolicitudEgreso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SucursalProductoExhibicion> SucursalProductoExhibicion { get; set; }
    }
}