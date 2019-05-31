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
    
    public partial class AnticipoCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnticipoCliente()
        {
            this.DevolucionCliente = new HashSet<DevolucionCliente>();
            this.FacturaCliente1 = new HashSet<FacturaCliente>();
            this.FacturaEspecial = new HashSet<FacturaEspecial>();
            this.NotaCredito = new HashSet<NotaCredito>();
            this.OrdenDespacho = new HashSet<OrdenDespacho>();
            this.PagoCliente = new HashSet<PagoCliente>();
            this.PedidoCliente = new HashSet<PedidoCliente>();
        }
    
        public System.Guid AnticipoCliente_Id { get; set; }
        public string SerieAnticipo { get; set; }
        public int FolioAnticipo { get; set; }
        public System.Guid Cliente_Id { get; set; }
        public int ClaveSucursalAnticipoCliente { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public decimal ImporteSinIVA { get; set; }
        public decimal PorcentajeIVA { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal ImporteConIVA { get; set; }
        public decimal Saldo { get; set; }
        public decimal Aplicado { get; set; }
        public decimal PorcentajeAnticipoCliente { get; set; }
        public int ClaveTipoMoneda { get; set; }
        public int FactorTipoCambio { get; set; }
        public Nullable<System.Guid> FacturaCliente_Id { get; set; }
        public string NotaAnticipoCliente { get; set; }
        public int OpcEstatusAnticipoCliente { get; set; }
        public int ClaveTipoFormaPago { get; set; }
        public Nullable<int> UsuarioAutorizaFormaPago { get; set; }
        public Nullable<System.DateTime> FechaAutorizaFormaPago { get; set; }
        public Nullable<int> UsuarioCancela { get; set; }
        public Nullable<System.DateTime> FechaCancela { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public decimal ImporteAjusteDSA { get; set; }
        public Nullable<int> UsuarioAutorizaAnticipo { get; set; }
        public Nullable<System.DateTime> FechaAutorizaAnticipo { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual FacturaCliente FacturaCliente { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual TipoMoneda TipoMoneda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevolucionCliente> DevolucionCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaCliente> FacturaCliente1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaEspecial> FacturaEspecial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCredito> NotaCredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDespacho> OrdenDespacho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoCliente> PagoCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoCliente> PedidoCliente { get; set; }
    }
}
