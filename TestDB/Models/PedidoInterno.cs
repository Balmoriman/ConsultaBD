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
    
    public partial class PedidoInterno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PedidoInterno()
        {
            this.PedidoInternoImportes = new HashSet<PedidoInternoImportes>();
            this.PedidoInternoProducto = new HashSet<PedidoInternoProducto>();
        }
    
        public string SeriePedidoInterno { get; set; }
        public int FolioPedidoInterno { get; set; }
        public short ClaveTipoPedidoInterno { get; set; }
        public Nullable<int> ClaveSucursalSolicita { get; set; }
        public Nullable<int> ClaveSucursalRecibe { get; set; }
        public Nullable<int> ClaveTipoMoneda { get; set; }
        public Nullable<int> ClaveTipoCambio { get; set; }
        public Nullable<decimal> ValorTipoCambio { get; set; }
        public string NotaPedidoInterno { get; set; }
        public int ClaveEstatusPedidoInterno { get; set; }
        public System.Guid Cliente_Id { get; set; }
        public Nullable<int> UsuarioComprador { get; set; }
        public Nullable<int> UsuarioVendedor { get; set; }
        public Nullable<int> UsuarioCancela { get; set; }
        public Nullable<System.DateTime> FechaCancela { get; set; }
        public Nullable<int> UsuarioAutoriza { get; set; }
        public Nullable<System.DateTime> FechaAutoriza { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string Contacto { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual EstatusPedidoInterno EstatusPedidoInterno { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual TipoCambio TipoCambio { get; set; }
        public virtual TipoPedidoInterno TipoPedidoInterno { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoInternoImportes> PedidoInternoImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoInternoProducto> PedidoInternoProducto { get; set; }
    }
}