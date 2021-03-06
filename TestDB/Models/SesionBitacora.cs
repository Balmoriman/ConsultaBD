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
    
    public partial class SesionBitacora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SesionBitacora()
        {
            this.SesionBitacoraActividad = new HashSet<SesionBitacoraActividad>();
        }
    
        public System.Guid Bitacora_Id { get; set; }
        public System.Guid Sesion_Id { get; set; }
        public int ClavePrograma { get; set; }
        public System.DateTime HoraEntrada { get; set; }
        public Nullable<System.DateTime> HoraSalida { get; set; }
        public string Parametros { get; set; }
    
        public virtual Programa Programa { get; set; }
        public virtual UsuarioSesion UsuarioSesion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SesionBitacoraActividad> SesionBitacoraActividad { get; set; }
    }
}
