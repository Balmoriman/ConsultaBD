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
    
    public partial class SeccionProductoCosto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeccionProductoCosto()
        {
            this.Kardex = new HashSet<Kardex>();
        }
    
        public System.Guid SeccionProductoID { get; set; }
        public decimal CostoPromedio { get; set; }
        public int CantidadSaldo { get; set; }
        public int ExistenciaSeccion { get; set; }
        public int ExistenciaExcedente { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kardex> Kardex { get; set; }
        public virtual SeccionProducto SeccionProducto { get; set; }
    }
}
