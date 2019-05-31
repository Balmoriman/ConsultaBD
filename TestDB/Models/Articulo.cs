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
    
    public partial class Articulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articulo()
        {
            this.InventarioFisicoProducto = new HashSet<InventarioFisicoProducto>();
            this.Producto = new HashSet<Producto>();
            this.SinonimoArticulo = new HashSet<SinonimoArticulo>();
        }
    
        public int ClaveArticulo { get; set; }
        public int ClaveArticuloSubGrupo { get; set; }
        public int ClaveArticuloGrupo { get; set; }
        public string CodigoArticulo { get; set; }
        public string NombreCorto { get; set; }
        public string NumericoArticulo { get; set; }
        public short ClaveUnidadMedida { get; set; }
        public string CodigoPresentacion { get; set; }
        public string Preposicion { get; set; }
        public int Cantidad { get; set; }
        public string CodigoUnidadPresentacion { get; set; }
        public string CodigoUnidad { get; set; }
        public string Presentacion { get; set; }
        public bool Activo { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string DescripcionPlantilla { get; set; }
        public Nullable<System.Guid> ArticuloDescripcionPlantilla_Id { get; set; }
    
        public virtual ArticuloSubGrupo ArticuloSubGrupo { get; set; }
        public virtual UnidadMedida UnidadMedida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioFisicoProducto> InventarioFisicoProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinonimoArticulo> SinonimoArticulo { get; set; }
    }
}