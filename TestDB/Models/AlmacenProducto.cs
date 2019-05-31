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
    
    public partial class AlmacenProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlmacenProducto()
        {
            this.SeccionProducto = new HashSet<SeccionProducto>();
        }
    
        public System.Guid AlmacenProductoId { get; set; }
        public System.Guid SucursalProductoId { get; set; }
        public int ClaveAlmacen { get; set; }
        public int ExistenciaMaxima { get; set; }
        public int ExistenciaMinima { get; set; }
        public bool Activo { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Almacen Almacen { get; set; }
        public virtual SucursalProducto SucursalProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeccionProducto> SeccionProducto { get; set; }
    }
}
