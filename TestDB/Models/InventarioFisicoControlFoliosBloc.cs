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
    
    public partial class InventarioFisicoControlFoliosBloc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventarioFisicoControlFoliosBloc()
        {
            this.InventarioFisicoRutaConteo = new HashSet<InventarioFisicoRutaConteo>();
        }
    
        public System.Guid InventarioFisicoControlFoliosBloc_Id { get; set; }
        public System.Guid InventarioFisicoControlFolios_Id { get; set; }
        public int FolioInicio { get; set; }
        public int FolioFin { get; set; }
        public Nullable<int> FolioUtilizadoInicio { get; set; }
        public Nullable<int> FolioUtilizadoFin { get; set; }
        public Nullable<System.Guid> InventarioFisicoEmpleado_Id { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual InventarioFisicoControlFolios InventarioFisicoControlFolios { get; set; }
        public virtual InventarioFisicoEmpleado InventarioFisicoEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioFisicoRutaConteo> InventarioFisicoRutaConteo { get; set; }
    }
}
