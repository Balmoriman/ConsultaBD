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
    
    public partial class OrdenCompraProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenCompraProducto()
        {
            this.OrdenCompraProductoExcedente = new HashSet<OrdenCompraProductoExcedente>();
            this.OrdenCompraProductoImportes = new HashSet<OrdenCompraProductoImportes>();
            this.OrdenCompraProductoSobrestock = new HashSet<OrdenCompraProductoSobrestock>();
        }
    
        public int ClaveOrdenCompraProductoPartida { get; set; }
        public Nullable<int> ClaveAlmacenSucursal { get; set; }
        public int ClaveArticulo { get; set; }
        public int ClaveMarcaLinea { get; set; }
        public int ClaveProductoSucursal { get; set; }
        public Nullable<int> ClaveSucursalDestino { get; set; }
        public Nullable<int> ClaveAlmacenDestino { get; set; }
        public string GrupoVentaABC { get; set; }
        public string DescripcionProducto { get; set; }
        public string CodigoFabrica { get; set; }
        public string CodigoUnidad { get; set; }
        public string Presentacion { get; set; }
        public Nullable<System.DateTime> FechaProgramadaRecepcion { get; set; }
        public Nullable<System.DateTime> FechaPromesaCompra { get; set; }
        public string SeriePedidoInterno { get; set; }
        public Nullable<int> FolioPedidoInterno { get; set; }
        public Nullable<int> ClavePedidoInternoPartida { get; set; }
        public Nullable<int> CantidadPactadaInicial { get; set; }
        public Nullable<int> CantidadPactadaActual { get; set; }
        public Nullable<int> CantidadExcedente { get; set; }
        public Nullable<int> CantidadSurtida { get; set; }
        public Nullable<int> CantidadCancelada { get; set; }
        public Nullable<int> CantidadSaldo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<decimal> PrecioListaProveedor { get; set; }
        public Nullable<decimal> PrecioCompra { get; set; }
        public Nullable<decimal> PrecioCostoIngreso { get; set; }
        public Nullable<decimal> PrecioPactado { get; set; }
        public Nullable<int> ClaveTipoMonedaOrigen { get; set; }
        public Nullable<int> ClaveTipoMonedaDestino { get; set; }
        public Nullable<decimal> FactorTipoCambio { get; set; }
        public string Descripcion1 { get; set; }
        public string Descripcion2 { get; set; }
        public Nullable<int> EstatusCompraProducto { get; set; }
        public Nullable<int> UsuarioCancela { get; set; }
        public Nullable<System.DateTime> FechaCancela { get; set; }
        public Nullable<int> UsuarioAutoriza { get; set; }
        public Nullable<System.DateTime> FechaAutoriza { get; set; }
        public Nullable<int> UsuarioExcedente { get; set; }
        public Nullable<System.DateTime> FechaExcedente { get; set; }
        public Nullable<int> ClaveAnticipoProveedor { get; set; }
        public Nullable<int> ClaveAnticipoProveedorSucursal { get; set; }
        public int NumeroEntradas { get; set; }
        public bool Confirmado { get; set; }
        public Nullable<decimal> PorcentajeAnticipo { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public System.Guid OrdenCompraProductoId { get; set; }
        public System.Guid OrdenCompraId { get; set; }
    
        public virtual OrdenCompra OrdenCompra { get; set; }
        public virtual PedidoInternoProducto PedidoInternoProducto { get; set; }
        public virtual Producto Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompraProductoExcedente> OrdenCompraProductoExcedente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompraProductoImportes> OrdenCompraProductoImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompraProductoSobrestock> OrdenCompraProductoSobrestock { get; set; }
    }
}
