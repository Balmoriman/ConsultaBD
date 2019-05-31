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
    
    public partial class OrdenDespacho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenDespacho()
        {
            this.DevolucionCliente = new HashSet<DevolucionCliente>();
            this.FacturaCliente = new HashSet<FacturaCliente>();
            this.ProductoPromocionCodigoAplicacion = new HashSet<ProductoPromocionCodigoAplicacion>();
            this.OrdenDespachoDocumento = new HashSet<OrdenDespachoDocumento>();
            this.OrdenDespachoEntregaBitacora = new HashSet<OrdenDespachoEntregaBitacora>();
            this.OrdenDespachoEquipo = new HashSet<OrdenDespachoEquipo>();
            this.OrdenDespachoProducto = new HashSet<OrdenDespachoProducto>();
            this.OrdenDespachoServicio = new HashSet<OrdenDespachoServicio>();
            this.TrackingOrdenDespacho = new HashSet<TrackingOrdenDespacho>();
        }
    
        public System.Guid OrdenDespachoId { get; set; }
        public int ClaveOrdenDespachoSucursal { get; set; }
        public int ClaveOrdenDespacho { get; set; }
        public System.Guid Cliente_Id { get; set; }
        public int ClaveSegmento3 { get; set; }
        public string SerieOrdenDespacho { get; set; }
        public int FolioOrdenDespacho { get; set; }
        public string RFC { get; set; }
        public string NombreLargo { get; set; }
        public string Colonia { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Pais { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public int OpcTipoEntrega { get; set; }
        public int EstatusFacturacion { get; set; }
        public bool ExisteFacturacion { get; set; }
        public string CorreoFacturacion { get; set; }
        public Nullable<System.DateTime> FechaFactura { get; set; }
        public Nullable<System.DateTime> FechaTentativaEntrega { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public string ColaboradorEntrega { get; set; }
        public Nullable<System.DateTime> FechaCancelacion { get; set; }
        public Nullable<System.DateTime> FechaPostFechado { get; set; }
        public Nullable<int> UsuarioAutorizaPostFechado { get; set; }
        public Nullable<short> ClaveTipoCredito { get; set; }
        public int DiasCredito { get; set; }
        public Nullable<int> ClavePromesaCompra { get; set; }
        public Nullable<int> ClavePromesaCompraSucursal { get; set; }
        public short ClaveCondicionVenta { get; set; }
        public short ClaveTipoFormaPago { get; set; }
        public int ClaveTipoMoneda { get; set; }
        public int ClaveTipoCambio { get; set; }
        public System.DateTime FechaTipoCambio { get; set; }
        public decimal ValorTipoCambio { get; set; }
        public int ClaveTipoDesgloseIVA { get; set; }
        public Nullable<int> ClaveDespachoMesaSucursalSucursal { get; set; }
        public Nullable<int> ClaveDespachoMesaSucursal { get; set; }
        public Nullable<int> NotaFactura { get; set; }
        public int Especial { get; set; }
        public Nullable<int> ClaveCanal { get; set; }
        public int ClaveVendedor { get; set; }
        public Nullable<int> ClaveRepresentante { get; set; }
        public int ClaveOrdenDespachoEstatus { get; set; }
        public int UsuarioEmitio { get; set; }
        public Nullable<int> UsuarioCancelo { get; set; }
        public Nullable<System.DateTime> FechaCancelo { get; set; }
        public Nullable<int> UsuarioAutoriza { get; set; }
        public Nullable<System.DateTime> FechaAutoriza { get; set; }
        public Nullable<int> ClavePedidoCliente { get; set; }
        public Nullable<int> ClavePedidoClienteSucursal { get; set; }
        public bool ImprimirDatosEnvio { get; set; }
        public int CopiasFactura { get; set; }
        public string Observacion { get; set; }
        public string NotasAlCliente { get; set; }
        public string ReferenciaClientePedido { get; set; }
        public Nullable<System.Guid> AnticipoCliente_Id { get; set; }
        public Nullable<decimal> PorcentajeAnticipo { get; set; }
        public string Detallista { get; set; }
        public Nullable<System.Guid> ClienteCredito_Id { get; set; }
        public Nullable<int> ClaveReferenciaNivel1 { get; set; }
        public Nullable<int> ClaveReferenciaNivel2 { get; set; }
        public Nullable<int> OpcDescripcion { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> UsuarioAutorizaFormaPago { get; set; }
        public Nullable<System.DateTime> FechaAutorizaFormaPago { get; set; }
        public string Solicitante { get; set; }
        public Nullable<System.Guid> ClienteContacto_Id { get; set; }
        public Nullable<int> UsuarioAutorizaQuitarPaqueteria { get; set; }
        public Nullable<int> UsuarioAutorizaAnticipo { get; set; }
        public Nullable<System.DateTime> FechaAutorizaAnticipo { get; set; }
        public Nullable<System.Guid> UsuarioExternoId { get; set; }
        public Nullable<int> EstatusOperacion { get; set; }
    
        public virtual AnticipoCliente AnticipoCliente { get; set; }
        public virtual CanalVenta CanalVenta { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ClienteCredito ClienteCredito { get; set; }
        public virtual ClienteReferenciaNivel2 ClienteReferenciaNivel2 { get; set; }
        public virtual ClienteSegmento3 ClienteSegmento3 { get; set; }
        public virtual CondicionVenta CondicionVenta { get; set; }
        public virtual DespachoMesaSucursal DespachoMesaSucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevolucionCliente> DevolucionCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaCliente> FacturaCliente { get; set; }
        public virtual OrdenDespachoEstatus OrdenDespachoEstatus { get; set; }
        public virtual OrdenDespachoImporte OrdenDespachoImporte { get; set; }
        public virtual PedidoCliente PedidoCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoPromocionCodigoAplicacion> ProductoPromocionCodigoAplicacion { get; set; }
        public virtual PromesaCompra PromesaCompra { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual TipoCambio TipoCambio { get; set; }
        public virtual TipoCredito TipoCredito { get; set; }
        public virtual TipoFormaPago TipoFormaPago { get; set; }
        public virtual TipoMoneda TipoMoneda { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDespachoDocumento> OrdenDespachoDocumento { get; set; }
        public virtual OrdenDespachoEntrega OrdenDespachoEntrega { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDespachoEntregaBitacora> OrdenDespachoEntregaBitacora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDespachoEquipo> OrdenDespachoEquipo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDespachoProducto> OrdenDespachoProducto { get; set; }
        public virtual OrdenDespachoReparto OrdenDespachoReparto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDespachoServicio> OrdenDespachoServicio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackingOrdenDespacho> TrackingOrdenDespacho { get; set; }
    }
}
