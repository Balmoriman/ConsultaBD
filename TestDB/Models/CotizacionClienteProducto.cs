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
    
    public partial class CotizacionClienteProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CotizacionClienteProducto()
        {
            this.CotizacionClienteProductoImportes = new HashSet<CotizacionClienteProductoImportes>();
        }
    
        public int ClaveCotizacionPartida { get; set; }
        public int ClaveCotizacionClienteSucursal { get; set; }
        public int ClaveCotizacionCliente { get; set; }
        public System.Guid CotizacionPartida_Id { get; set; }
        public Nullable<int> ClaveAlmacenSucursal { get; set; }
        public int ClaveArticulo { get; set; }
        public int ClaveMarcaLinea { get; set; }
        public int CantidadExistencia { get; set; }
        public int CantidadSolicitada { get; set; }
        public int CantidadSaldo { get; set; }
        public string GrupoVentaABC { get; set; }
        public string DescripcionProducto { get; set; }
        public string CodigoFabrica { get; set; }
        public string CodigoUnidad { get; set; }
        public string Presentacion { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal PrecioCreditoOrigen { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal CostoPromedio { get; set; }
        public int ClaveTipoMonedaOrigen { get; set; }
        public int ClaveTipoMonedaDestino { get; set; }
        public decimal FactorTipoCambio { get; set; }
        public int ExistenciaMinima { get; set; }
        public int ExistenciaMaxima { get; set; }
        public string DescripcionCliente1 { get; set; }
        public string DescripcionCliente2 { get; set; }
        public int EstatusCotizacionClienteProducto { get; set; }
        public Nullable<System.Guid> ProductoPromocion_Id { get; set; }
        public Nullable<int> PartidaPromocion { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual CotizacionCliente CotizacionCliente { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual ProductoPromocionDetalle ProductoPromocionDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionClienteProductoImportes> CotizacionClienteProductoImportes { get; set; }
    }
}