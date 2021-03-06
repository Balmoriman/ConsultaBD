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
    
    public partial class TrackingOrdenDespacho
    {
        public System.Guid TrackingOrdenDespachoId { get; set; }
        public System.Guid OrdenDespachoId { get; set; }
        public string SerieOrdenDespacho { get; set; }
        public int FolioOrdenDespacho { get; set; }
        public int ClaveSucursal { get; set; }
        public string Sucursal { get; set; }
        public Nullable<int> ClaveSeccion { get; set; }
        public string NombreSeccion { get; set; }
        public int OpcTipoEntrega { get; set; }
        public string TipoEntrega { get; set; }
        public string Destino { get; set; }
        public Nullable<int> ClaveRutaReparto { get; set; }
        public string RutaReparto { get; set; }
        public int ClaveCanal { get; set; }
        public string CanalVenta { get; set; }
        public Nullable<System.Guid> FacturaClienteId { get; set; }
        public string SerieFactura { get; set; }
        public Nullable<int> FolioFactura { get; set; }
        public System.Guid ClienteId { get; set; }
        public int ClaveCliente { get; set; }
        public string NombreLargo { get; set; }
        public Nullable<System.DateTime> FechaGeneracionOddInicio { get; set; }
        public Nullable<System.DateTime> FechaGeneracionOddFin { get; set; }
        public Nullable<int> TiempoGeneracionOdd { get; set; }
        public Nullable<int> ClaveUsuarioGeneracionOdd { get; set; }
        public Nullable<int> ClaveEmpleadoGeneracionOdd { get; set; }
        public string NombreEmpleadoGeneracionOdd { get; set; }
        public string PuestoEmpleadoGeneracionOdd { get; set; }
        public Nullable<System.DateTime> FechaEmitirFacturaInicio { get; set; }
        public Nullable<System.DateTime> FechaEmitirFacturaFin { get; set; }
        public Nullable<int> TiempoEmitirFactura { get; set; }
        public Nullable<int> ClaveUsuarioEmitirFactura { get; set; }
        public Nullable<int> ClaveEmpleadoEmitirFactura { get; set; }
        public string NombreEmpleadoEmitirFactura { get; set; }
        public string PuestoEmpleadoEmitirFactura { get; set; }
        public Nullable<System.DateTime> FechaEntregaSeccionInicio { get; set; }
        public Nullable<System.DateTime> FechaEntregaSeccionFin { get; set; }
        public Nullable<int> TiempoEntregaSeccionMesa { get; set; }
        public Nullable<int> ClaveUsuarioEntregaSeccionMesa { get; set; }
        public string CurpEmpleadoSeccion { get; set; }
        public Nullable<int> ClaveEmpleadoEntregaSeccionMesa { get; set; }
        public string NombreEmpleadoEntregaSeccionMesa { get; set; }
        public string PuestoEmpleadoEntregaSeccionMesa { get; set; }
        public Nullable<System.DateTime> FechaEntregaMercanciaInicio { get; set; }
        public Nullable<System.DateTime> FechaEntregaMercanciaFin { get; set; }
        public Nullable<int> TiempoEntregaMercancia { get; set; }
        public Nullable<int> ClaveUsuarioEntregaMercancia { get; set; }
        public string CurpEmpleadoMesa { get; set; }
        public Nullable<int> ClaveEmpleadoEntregaMercancia { get; set; }
        public string NombreEmpleadoEntregaMercancia { get; set; }
        public string PuestoEmpleadoEntregaMercancia { get; set; }
        public Nullable<System.DateTime> FechaGenerarRutaInicio { get; set; }
        public Nullable<System.DateTime> FechaGenerarRutaFin { get; set; }
        public Nullable<int> TiempoGenerarRuta { get; set; }
        public Nullable<int> ClaveUsuarioGenerarRuta { get; set; }
        public Nullable<int> ClaveEmpleadoGenerarRuta { get; set; }
        public string NombreEmpleadoGenerarRuta { get; set; }
        public string PuestoEmpleadoGenerarRuta { get; set; }
        public Nullable<System.DateTime> FechaEmitirPorRutaInicio { get; set; }
        public Nullable<System.DateTime> FechaEmitirPorRutaFin { get; set; }
        public Nullable<int> TiempoEmitirPorRuta { get; set; }
        public Nullable<int> ClaveUsuarioEmitirPorRuta { get; set; }
        public Nullable<int> ClaveEmpleadoEmitirPorRuta { get; set; }
        public string NombreEmpleadoEmitirPorRuta { get; set; }
        public string PuestoEmpleadoEmitirPorRuta { get; set; }
        public Nullable<System.DateTime> FechaEmitirSinRutaInicio { get; set; }
        public Nullable<System.DateTime> FechaEmitirSinRutaFin { get; set; }
        public Nullable<int> TiempoEmitirSinRuta { get; set; }
        public Nullable<int> ClaveUsuarioEmitirPoSinRuta { get; set; }
        public Nullable<int> ClaveEmpleadoEmitirSinRuta { get; set; }
        public string NombreEmpleadoEmitirSinRuta { get; set; }
        public string PuestoEmpleadoEmitirSinRuta { get; set; }
        public Nullable<System.DateTime> FechaControlRutaInicio { get; set; }
        public Nullable<System.DateTime> FechaControlRutaFin { get; set; }
        public Nullable<int> TiempoControlRuta { get; set; }
        public Nullable<int> ClaveUsuarioControlRuta { get; set; }
        public Nullable<int> ClaveEmpleadoControlRuta { get; set; }
        public string NombreEmpleadoControlRuta { get; set; }
        public string PuestoEmpleadoControlRuta { get; set; }
        public Nullable<System.DateTime> FechaRecibirRutaInicio { get; set; }
        public Nullable<System.DateTime> FechaRecibirRutaFin { get; set; }
        public Nullable<int> TiempoRecibirRuta { get; set; }
        public Nullable<int> ClaveUsuarioRecibirRuta { get; set; }
        public Nullable<int> ClaveEmpleadoRecibirRuta { get; set; }
        public string NombreEmpleadoRecibirRuta { get; set; }
        public string PuestoEmpleadoRecibirRuta { get; set; }
        public Nullable<System.DateTime> FechaEntregaRutaInicio { get; set; }
        public Nullable<System.DateTime> FechaEntregaRutaFin { get; set; }
        public Nullable<int> TiempoEntregaRuta { get; set; }
        public string CurpEmpleadoChofer { get; set; }
        public Nullable<int> ClaveEmpleadoChofer { get; set; }
        public string NombreEmpleadoChofer { get; set; }
        public string PuestoEmpleadoChofer { get; set; }
        public Nullable<int> TiempoProcesoCompleto { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual FacturaCliente FacturaCliente { get; set; }
        public virtual OrdenDespacho OrdenDespacho { get; set; }
    }
}
