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
    
    public partial class ReciboProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReciboProducto()
        {
            this.IngresosDocumentos = new HashSet<IngresosDocumentos>();
            this.ReciboProductoDetalle = new HashSet<ReciboProductoDetalle>();
        }
    
        public int ClaveReciboProductoSucursal { get; set; }
        public System.Guid ReciboProductoId { get; set; }
        public Nullable<int> OpcTipoDocumentoRecibe { get; set; }
        public string IdDocumentoRecibe { get; set; }
        public Nullable<int> ClaveAlmacenRecibo { get; set; }
        public int ClaveAlmacenReciboSucursal { get; set; }
        public int ClaveTipoDocumentoOrigen { get; set; }
        public int ClaveDocumentoOrigen { get; set; }
        public int ClaveDocumentoOrigenSucursal { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> ImporteTotal { get; set; }
        public Nullable<int> ClaveTipoMonedaOrigen { get; set; }
        public Nullable<int> ClaveTipoMonedaDestino { get; set; }
        public Nullable<decimal> FactorTipoCambio { get; set; }
        public string NotaRecepcion { get; set; }
        public Nullable<int> UsuarioRecibe { get; set; }
        public Nullable<System.DateTime> FechaRecibe { get; set; }
        public Nullable<decimal> ImporteTotalFactura { get; set; }
        public Nullable<decimal> ImporteTotalOrdenCompra { get; set; }
        public Nullable<decimal> ImporteTotalIngreso { get; set; }
        public Nullable<decimal> DiferenciaFacturaVSOrdenCompra { get; set; }
        public Nullable<decimal> DiferenciaFacturaVSIngreso { get; set; }
        public decimal AjusteRedondeo { get; set; }
        public System.TimeSpan HoraInicio { get; set; }
        public System.TimeSpan HoraFinal { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> OpcEstatusReciboProducto { get; set; }
        public string SerieReciboProducto { get; set; }
        public int FolioReciboProducto { get; set; }
        public Nullable<System.Guid> OrdenCompraId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngresosDocumentos> IngresosDocumentos { get; set; }
        public virtual OrdenCompra OrdenCompra { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReciboProductoDetalle> ReciboProductoDetalle { get; set; }
    }
}