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
    
    public partial class EfectivoEnResguardo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EfectivoEnResguardo()
        {
            this.EntregaEfectivoDetalle = new HashSet<EntregaEfectivoDetalle>();
        }
    
        public System.Guid EfectivoEnResguardo_Id { get; set; }
        public string SerieEfectivoEnResguardo { get; set; }
        public int FolioEfectivoEnResguardo { get; set; }
        public System.Guid SesionCaja_Id { get; set; }
        public string Denominaciones { get; set; }
        public decimal Monto { get; set; }
        public string Referencia { get; set; }
        public int ClaveUsuarioEntrega { get; set; }
        public int ClaveUsuarioRecibe { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual SesionCaja SesionCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntregaEfectivoDetalle> EntregaEfectivoDetalle { get; set; }
    }
}
