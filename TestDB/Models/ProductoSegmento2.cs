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
    
    public partial class ProductoSegmento2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductoSegmento2()
        {
            this.ArticuloDescripcionPlantilla = new HashSet<ArticuloDescripcionPlantilla>();
            this.ProductoSegmento3 = new HashSet<ProductoSegmento3>();
        }
    
        public string ClaveProductoSegmento2 { get; set; }
        public string ClaveProductoSegmento1 { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticuloDescripcionPlantilla> ArticuloDescripcionPlantilla { get; set; }
        public virtual ProductoSegmento1 ProductoSegmento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoSegmento3> ProductoSegmento3 { get; set; }
    }
}
