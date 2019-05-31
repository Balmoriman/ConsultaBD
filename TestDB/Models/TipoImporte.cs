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
    
    public partial class TipoImporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoImporte()
        {
            this.CargoClienteImportes = new HashSet<CargoClienteImportes>();
            this.CotizacionClienteImportes = new HashSet<CotizacionClienteImportes>();
            this.CotizacionClienteImportesHojaTrabajo = new HashSet<CotizacionClienteImportesHojaTrabajo>();
            this.CotizacionClienteProductoImportes = new HashSet<CotizacionClienteProductoImportes>();
            this.CotizacionClienteProductoImportesHojaTrabajo = new HashSet<CotizacionClienteProductoImportesHojaTrabajo>();
            this.DevolucionClienteImporte = new HashSet<DevolucionClienteImporte>();
            this.DevolucionClienteProductoImporte = new HashSet<DevolucionClienteProductoImporte>();
            this.FacturaClienteImportes = new HashSet<FacturaClienteImportes>();
            this.NotaCargoImportes = new HashSet<NotaCargoImportes>();
            this.NotaCreditoImportes = new HashSet<NotaCreditoImportes>();
            this.OrdenCompraImportes = new HashSet<OrdenCompraImportes>();
            this.OrdenCompraProductoImportes = new HashSet<OrdenCompraProductoImportes>();
            this.PedidoClienteImportes = new HashSet<PedidoClienteImportes>();
            this.PedidoClienteProductoImportes = new HashSet<PedidoClienteProductoImportes>();
            this.PedidoInternoImportes = new HashSet<PedidoInternoImportes>();
            this.PedidoInternoProductoImportes = new HashSet<PedidoInternoProductoImportes>();
            this.TipoDescuentoImporte = new HashSet<TipoDescuentoImporte>();
        }
    
        public int ClaveTipoImporte { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargoClienteImportes> CargoClienteImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionClienteImportes> CotizacionClienteImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionClienteImportesHojaTrabajo> CotizacionClienteImportesHojaTrabajo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionClienteProductoImportes> CotizacionClienteProductoImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionClienteProductoImportesHojaTrabajo> CotizacionClienteProductoImportesHojaTrabajo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevolucionClienteImporte> DevolucionClienteImporte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevolucionClienteProductoImporte> DevolucionClienteProductoImporte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaClienteImportes> FacturaClienteImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCargoImportes> NotaCargoImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCreditoImportes> NotaCreditoImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompraImportes> OrdenCompraImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCompraProductoImportes> OrdenCompraProductoImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoClienteImportes> PedidoClienteImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoClienteProductoImportes> PedidoClienteProductoImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoInternoImportes> PedidoInternoImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoInternoProductoImportes> PedidoInternoProductoImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoDescuentoImporte> TipoDescuentoImporte { get; set; }
    }
}