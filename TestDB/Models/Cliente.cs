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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.AnticipoCliente = new HashSet<AnticipoCliente>();
            this.BitacoraAddenda = new HashSet<BitacoraAddenda>();
            this.CargoCliente = new HashSet<CargoCliente>();
            this.ProductoPromocionCodigoAplicacion = new HashSet<ProductoPromocionCodigoAplicacion>();
            this.ClienteAvisoPago = new HashSet<ClienteAvisoPago>();
            this.ClienteCalendario = new HashSet<ClienteCalendario>();
            this.ClienteCondicionesSantiago = new HashSet<ClienteCondicionesSantiago>();
            this.ClienteContacto = new HashSet<ClienteContacto>();
            this.ClienteDescripcion = new HashSet<ClienteDescripcion>();
            this.ClienteDescuento = new HashSet<ClienteDescuento>();
            this.ClienteDireccion = new HashSet<ClienteDireccion>();
            this.ClienteDocumentos = new HashSet<ClienteDocumentos>();
            this.ClienteEnvioFiscal = new HashSet<ClienteEnvioFiscal>();
            this.ClienteEquipo = new HashSet<ClienteEquipo>();
            this.ClienteReferenciaNivel1 = new HashSet<ClienteReferenciaNivel1>();
            this.ClienteSolicitudCheque = new HashSet<ClienteSolicitudCheque>();
            this.ClienteSolicitudCredito = new HashSet<ClienteSolicitudCredito>();
            this.ClienteTipoFormaPago = new HashSet<ClienteTipoFormaPago>();
            this.CotizacionCliente = new HashSet<CotizacionCliente>();
            this.CotizacionClienteHojaTrabajo = new HashSet<CotizacionClienteHojaTrabajo>();
            this.CuentaCobrarCliente = new HashSet<CuentaCobrarCliente>();
            this.CuentaCobrarClienteMovimiento = new HashSet<CuentaCobrarClienteMovimiento>();
            this.DevolucionCliente = new HashSet<DevolucionCliente>();
            this.FacturaCliente = new HashSet<FacturaCliente>();
            this.FacturaEspecial = new HashSet<FacturaEspecial>();
            this.Kardex = new HashSet<Kardex>();
            this.NotaCargo = new HashSet<NotaCargo>();
            this.NotaCredito = new HashSet<NotaCredito>();
            this.OrdenDespacho = new HashSet<OrdenDespacho>();
            this.OrdenEnsamble = new HashSet<OrdenEnsamble>();
            this.PagoCliente = new HashSet<PagoCliente>();
            this.PagoCobranza = new HashSet<PagoCobranza>();
            this.PedidoCliente = new HashSet<PedidoCliente>();
            this.PedidoInterno = new HashSet<PedidoInterno>();
            this.ProductoNegadoCatalogo = new HashSet<ProductoNegadoCatalogo>();
            this.ProductoPromocionCliente = new HashSet<ProductoPromocionCliente>();
            this.PromesaCompra = new HashSet<PromesaCompra>();
            this.TrackingOrdenDespacho = new HashSet<TrackingOrdenDespacho>();
        }
    
        public System.Guid Cliente_Id { get; set; }
        public int ClaveCliente { get; set; }
        public int ClaveClienteSucursal { get; set; }
        public string LiteralesRFC { get; set; }
        public string NumeralesRFC { get; set; }
        public string HomoclaveRFC { get; set; }
        public string RFC { get; set; }
        public string emailFacturacion { get; set; }
        public int EnviarFactura { get; set; }
        public int RequiereFactura { get; set; }
        public string NombreLargo { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string RazonSocial { get; set; }
        public Nullable<System.DateTime> FechaInicioOperacionFiscal { get; set; }
        public short OpcClienteTipoFiscal { get; set; }
        public string Frecuencia1 { get; set; }
        public string Frecuencia2 { get; set; }
        public string Frecuencia3 { get; set; }
        public string ABC1 { get; set; }
        public string ABC2 { get; set; }
        public string ABC3 { get; set; }
        public int ClaveSegmento3 { get; set; }
        public string NotaSegmentacion { get; set; }
        public string MensajeCaja { get; set; }
        public string MensajeVentas { get; set; }
        public short ClaveClienteEstatus { get; set; }
        public int OpcTipoIva { get; set; }
        public string ReferenciaBancaria { get; set; }
        public bool ReportaBuroCredito { get; set; }
        public bool BuroCredito { get; set; }
        public Nullable<System.DateTime> FechaUltimaCompra { get; set; }
        public int CopiasFacturacion { get; set; }
        public int OpcLugarPago { get; set; }
        public Nullable<System.Guid> ClienteCredito_Id { get; set; }
        public Nullable<System.Guid> ClienteCheque_Id { get; set; }
        public Nullable<System.Guid> Addenda_Id { get; set; }
        public int OpcMedioCompra { get; set; }
        public string Observaciones { get; set; }
        public string CodigoPais { get; set; }
        public string CodigoLada { get; set; }
        public string Telefono { get; set; }
        public string Extension { get; set; }
        public string FormaPago { get; set; }
        public string NumeroCuenta { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> ClaveGrupo { get; set; }
        public Nullable<int> ClaveUsoCFDI { get; set; }
        public string BuzonFiscal { get; set; }
        public bool RfcVerificado { get; set; }
        public Nullable<int> TipoComplementoPago { get; set; }
        public Nullable<int> ClaveBanco { get; set; }
        public string CuentaOrdenante { get; set; }
        public bool PagoPorTransferencia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnticipoCliente> AnticipoCliente { get; set; }
        public virtual Banco Banco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BitacoraAddenda> BitacoraAddenda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargoCliente> CargoCliente { get; set; }
        public virtual ClienteAddenda ClienteAddenda { get; set; }
        public virtual ClienteCheque ClienteCheque { get; set; }
        public virtual ClienteCredito ClienteCredito { get; set; }
        public virtual ClienteEstatus ClienteEstatus { get; set; }
        public virtual ClienteGrupo ClienteGrupo { get; set; }
        public virtual ClienteSegmento3 ClienteSegmento3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoPromocionCodigoAplicacion> ProductoPromocionCodigoAplicacion { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteAvisoPago> ClienteAvisoPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteCalendario> ClienteCalendario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteCondicionesSantiago> ClienteCondicionesSantiago { get; set; }
        public virtual ClienteCondicionVenta ClienteCondicionVenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteContacto> ClienteContacto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteDescripcion> ClienteDescripcion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteDescuento> ClienteDescuento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteDireccion> ClienteDireccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteDocumentos> ClienteDocumentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteEnvioFiscal> ClienteEnvioFiscal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteEquipo> ClienteEquipo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteReferenciaNivel1> ClienteReferenciaNivel1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteSolicitudCheque> ClienteSolicitudCheque { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteSolicitudCredito> ClienteSolicitudCredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteTipoFormaPago> ClienteTipoFormaPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionCliente> CotizacionCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionClienteHojaTrabajo> CotizacionClienteHojaTrabajo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaCobrarCliente> CuentaCobrarCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaCobrarClienteMovimiento> CuentaCobrarClienteMovimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevolucionCliente> DevolucionCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaCliente> FacturaCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaEspecial> FacturaEspecial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kardex> Kardex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCargo> NotaCargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCredito> NotaCredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDespacho> OrdenDespacho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenEnsamble> OrdenEnsamble { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoCliente> PagoCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoCobranza> PagoCobranza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoCliente> PedidoCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoInterno> PedidoInterno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoNegadoCatalogo> ProductoNegadoCatalogo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoPromocionCliente> ProductoPromocionCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PromesaCompra> PromesaCompra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackingOrdenDespacho> TrackingOrdenDespacho { get; set; }
    }
}
