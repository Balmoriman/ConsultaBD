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
    
    public partial class SesionFacturaEntrega
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SesionFacturaEntrega()
        {
            this.SesionFacturaEntregaDetalle = new HashSet<SesionFacturaEntregaDetalle>();
        }
    
        public System.Guid Entrega_Id { get; set; }
        public int OpcOrigen { get; set; }
        public string SerieEntrega { get; set; }
        public int FolioEntrega { get; set; }
        public int opcEstatusEntrega { get; set; }
        public System.Guid SesionCaja_Id { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int UsuarioAlta { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<int> ClaveUsuarioRecibe { get; set; }
        public Nullable<System.DateTime> FechaRecibe { get; set; }
    
        public virtual SesionCaja SesionCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SesionFacturaEntregaDetalle> SesionFacturaEntregaDetalle { get; set; }
    }
}
