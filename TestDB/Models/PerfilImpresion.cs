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
    
    public partial class PerfilImpresion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PerfilImpresion()
        {
            this.Dispositivo = new HashSet<Dispositivo>();
            this.PerfilImpresionGrupo = new HashSet<PerfilImpresionGrupo>();
        }
    
        public System.Guid PerfilImpresion_Id { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dispositivo> Dispositivo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerfilImpresionGrupo> PerfilImpresionGrupo { get; set; }
    }
}