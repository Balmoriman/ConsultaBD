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
    
    public partial class InventarioFisicoMarbete
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventarioFisicoMarbete()
        {
            this.InventarioFisicoImpresion = new HashSet<InventarioFisicoImpresion>();
            this.InventarioFisicoMarbeteHistorico = new HashSet<InventarioFisicoMarbeteHistorico>();
        }
    
        public System.Guid InventarioFisicoMarbete_Id { get; set; }
        public System.Guid InventarioFisico_Id { get; set; }
        public System.Guid InventarioFisicoProducto_Id { get; set; }
        public System.Guid InventarioFisicoUbicacion_Id { get; set; }
        public Nullable<System.Guid> InventarioFisicoIdentificadorCorte_Id { get; set; }
        public int Folio { get; set; }
        public int ClaveMarbeteConteoActual { get; set; }
        public Nullable<int> ClaveMarbeteConteoFinal { get; set; }
        public int ClaveEstatus { get; set; }
        public int Imprimir { get; set; }
        public Nullable<int> UsuarioAutorizaUbicacion { get; set; }
        public Nullable<int> UsuarioRevision { get; set; }
        public Nullable<System.DateTime> FechaUltimaRevision { get; set; }
        public Nullable<int> UsuarioAuditoria { get; set; }
        public Nullable<System.DateTime> FechaUltimaAuditoria { get; set; }
        public Nullable<int> UsuarioCancela { get; set; }
        public Nullable<System.DateTime> FechaCancela { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual InventarioFisico InventarioFisico { get; set; }
        public virtual InventarioFisicoIdentificadorCorte InventarioFisicoIdentificadorCorte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioFisicoImpresion> InventarioFisicoImpresion { get; set; }
        public virtual InventarioFisicoProducto InventarioFisicoProducto { get; set; }
        public virtual InventarioFisicoUbicacion InventarioFisicoUbicacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioFisicoMarbeteHistorico> InventarioFisicoMarbeteHistorico { get; set; }
    }
}
