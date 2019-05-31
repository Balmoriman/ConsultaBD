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
    
    public partial class CotizacionClienteProductoHojaTrabajo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CotizacionClienteProductoHojaTrabajo()
        {
            this.CotizacionClienteProductoImportesHojaTrabajo = new HashSet<CotizacionClienteProductoImportesHojaTrabajo>();
        }
    
        public int ClaveCotizacionPartida { get; set; }
        public int ClaveCotizacionClienteSucursal { get; set; }
        public int ClaveCotizacionCliente { get; set; }
        public System.Guid HojaTrabajoPartida_Id { get; set; }
        public int ClaveAlmacenSucursal { get; set; }
        public int ClaveArticulo { get; set; }
        public int ClaveMarcaLinea { get; set; }
        public int CantidadExistencia { get; set; }
        public int CantidadSolicitada { get; set; }
        public string GrupoVentaABC { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal PrecioCreditoOrigen { get; set; }
        public decimal PrecioVenta { get; set; }
        public int ClaveTipoMonedaOrigen { get; set; }
        public int ClaveTipoMonedaDestino { get; set; }
        public decimal FactorTipoCambio { get; set; }
        public int ExistenciaMinima { get; set; }
        public int ExistenciaMaxima { get; set; }
        public string DescripcionCliente1 { get; set; }
        public string DescripcionCliente2 { get; set; }
        public Nullable<int> EstatusCotizacionClienteProducto { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual CotizacionClienteHojaTrabajo CotizacionClienteHojaTrabajo { get; set; }
        public virtual Producto Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CotizacionClienteProductoImportesHojaTrabajo> CotizacionClienteProductoImportesHojaTrabajo { get; set; }
    }
}