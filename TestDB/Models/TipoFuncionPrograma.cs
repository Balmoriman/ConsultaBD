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
    
    public partial class TipoFuncionPrograma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoFuncionPrograma()
        {
            this.AutorizacionLimites = new HashSet<AutorizacionLimites>();
            this.Perfil = new HashSet<Perfil>();
            this.ProgramaFuncion = new HashSet<ProgramaFuncion>();
        }
    
        public int ClaveTipoFuncionPrograma { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutorizacionLimites> AutorizacionLimites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perfil> Perfil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramaFuncion> ProgramaFuncion { get; set; }
    }
}
