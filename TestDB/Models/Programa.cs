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
    
    public partial class Programa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Programa()
        {
            this.AutorizacionLimites = new HashSet<AutorizacionLimites>();
            this.Menu = new HashSet<Menu>();
            this.ProcesoPrograma = new HashSet<ProcesoPrograma>();
            this.ProgramaConfiguracion = new HashSet<ProgramaConfiguracion>();
            this.ProgramaFuncion = new HashSet<ProgramaFuncion>();
            this.SesionBitacora = new HashSet<SesionBitacora>();
        }
    
        public int ClavePrograma { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.Guid> Notificacion_Id { get; set; }
        public string Ayuda { get; set; }
        public string RutaAplicacion { get; set; }
        public bool Activo { get; set; }
        public string Configuracion { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutorizacionLimites> AutorizacionLimites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual Notificacion Notificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcesoPrograma> ProcesoPrograma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramaConfiguracion> ProgramaConfiguracion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramaFuncion> ProgramaFuncion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SesionBitacora> SesionBitacora { get; set; }
    }
}
