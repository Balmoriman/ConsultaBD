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
    
    public partial class ExhibicionUbicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExhibicionUbicacion()
        {
            this.SucursalProductoExhibicion = new HashSet<SucursalProductoExhibicion>();
        }
    
        public System.Guid ExhibicionUbicacion_Id { get; set; }
        public int ClaveSucursal { get; set; }
        public System.Guid AreaUbicacion_Id { get; set; }
        public Nullable<System.Guid> UbicacionId { get; set; }
        public System.Guid TipoUbicacion_Id { get; set; }
        public int Division { get; set; }
        public int Nivel { get; set; }
        public string CodigoUbicacion { get; set; }
        public int Estatus { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SucursalProductoExhibicion> SucursalProductoExhibicion { get; set; }
    }
}
