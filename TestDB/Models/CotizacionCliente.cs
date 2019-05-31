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
    
    public partial class CotizacionCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CotizacionCliente()
        {
            this.CotizacionClienteImportes = new HashSet<CotizacionClienteImportes>();
            this.CotizacionClienteProducto = new HashSet<CotizacionClienteProducto>();
        }
    
        public int ClaveCotizacionCliente { get; set; }
        public int ClaveCotizacionClienteSucursal { get; set; }
        public System.Guid Cotizacion_Id { get; set; }
        public string SerieCotizacion { get; set; }
        public int FolioCotizacion { get; set; }
        public System.Guid Cliente_Id { get; set; }
        public string RFC { get; set; }
        public string NombreLargo { get; set; }
        public string Colonia { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Pais { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public decimal FactorDescuento { get; set; }
        public int ClaveTipoMoneda { get; set; }
        public int ClaveTipoCambio { get; set; }
        public Nullable<decimal> ValorTipoCambio { get; set; }
        public string NombreSolicitante1 { get; set; }
        public string NombreSolicitante2 { get; set; }
        public string ApellidoPaternoSolicitante { get; set; }
        public string ApellidoMaternoSolicitante { get; set; }
        public string CorreoElectronicoSolicitante { get; set; }
        public Nullable<int> OpcTipoTelefono { get; set; }
        public string CodigoPais { get; set; }
        public string CodigoLada { get; set; }
        public string Telefono { get; set; }
        public string Extension { get; set; }
        public Nullable<bool> Especial { get; set; }
        public string NotaCotizacion { get; set; }
        public int ClaveEstatusCotizacion { get; set; }
        public Nullable<int> UsuarioCancela { get; set; }
        public Nullable<System.DateTime> FechaCancela { get; set; }
        public Nullable<int> UsuarioAutoriza { get; set; }
        public Nullable<System.DateTime> FechaAutoriza { get; set; }
        public Nullable<int> UsuarioSesion { get; set; }
        public Nullable<System.DateTime> FechaSesion { get; set; }
        public string Descripcion { get; set; }
        public int Version { get; set; }
        public Nullable<int> ClaveRepresentante { get; set; }
        public Nullable<int> ClaveVendedor { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string Contacto { get; set; }
        public Nullable<System.Guid> ClienteContacto_Id { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual ClienteContacto ClienteContacto { get; set; }
        public virtual EstatusCotizacion EstatusCotizacion { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual TipoCambio TipoCambio { get; set; }
        public virtual TipoMoneda TipoMoneda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionClienteImportes> CotizacionClienteImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionClienteProducto> CotizacionClienteProducto { get; set; }
    }
}
