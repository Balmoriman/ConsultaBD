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
    
    public partial class InventarioTransito
    {
        public System.Guid Transito_ID { get; set; }
        public string Serie { get; set; }
        public int Folio { get; set; }
        public int Partida { get; set; }
        public int ClaveTipoMovimientoInventario { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public int CantidadInicial { get; set; }
        public int CantidadMovimiento { get; set; }
        public int CantidadSaldo { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> ClaveEmpleadoEnRuta { get; set; }
        public Nullable<short> ClaveConceptoRechazoMercancia { get; set; }
        public int Estatus { get; set; }
        public Nullable<System.Guid> KardexId { get; set; }
        public Nullable<int> UsuarioAutoriza { get; set; }
        public Nullable<int> UsuarioAjuste { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Kardex Kardex { get; set; }
        public virtual TipoRechazoMercancia TipoRechazoMercancia { get; set; }
        public virtual ValeInterAlmacenProducto ValeInterAlmacenProducto { get; set; }
        public virtual TipoMovimientoInventario TipoMovimientoInventario { get; set; }
    }
}
