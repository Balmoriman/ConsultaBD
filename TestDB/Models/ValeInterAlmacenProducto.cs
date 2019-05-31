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
    
    public partial class ValeInterAlmacenProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ValeInterAlmacenProducto()
        {
            this.InventarioTransito = new HashSet<InventarioTransito>();
        }
    
        public string Serie { get; set; }
        public int Folio { get; set; }
        public int Partida { get; set; }
        public int ClaveArticulo { get; set; }
        public int ClaveMarcaLinea { get; set; }
        public int CantidadExistenciaOrigen { get; set; }
        public int CantidadSolicitada { get; set; }
        public Nullable<int> CantidadAceptada { get; set; }
        public Nullable<int> CantidadExistenciaDestino { get; set; }
        public Nullable<int> CantidadDespacho { get; set; }
        public Nullable<int> CantidadSolicitadaResguardo { get; set; }
        public Nullable<int> DiferenciaAceptadoDespacho { get; set; }
        public Nullable<int> CantidadRecibida { get; set; }
        public Nullable<int> CantidadTransito { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Costo { get; set; }
        public System.Guid ProductoOrigenId { get; set; }
        public System.Guid SeccionProductoOrigenId { get; set; }
        public Nullable<System.Guid> ProductoDestinoId { get; set; }
        public Nullable<int> ClaveTipoMonedaOrigen { get; set; }
        public Nullable<int> ClaveTipoMonedaDestino { get; set; }
        public Nullable<decimal> FactorTipoCambio { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<System.Guid> OrdenCorte_Id { get; set; }
        public Nullable<System.Guid> IdentificadorCorte_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioTransito> InventarioTransito { get; set; }
        public virtual OrdenCorte OrdenCorte { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual ProductoIdentificadorCorte ProductoIdentificadorCorte { get; set; }
        public virtual ValeInterAlmacen ValeInterAlmacen { get; set; }
    }
}
