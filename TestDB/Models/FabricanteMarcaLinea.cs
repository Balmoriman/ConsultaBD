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
    
    public partial class FabricanteMarcaLinea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FabricanteMarcaLinea()
        {
            this.InventarioFisicoProducto = new HashSet<InventarioFisicoProducto>();
            this.PrecioAvisoCambio = new HashSet<PrecioAvisoCambio>();
            this.Producto = new HashSet<Producto>();
        }
    
        public int ClaveMarcaLinea { get; set; }
        public int ClaveFabricante { get; set; }
        public string CodigoMarca { get; set; }
        public string Nombre { get; set; }
        public string Linea { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> UsuarioResponsable { get; set; }
        public string NombreMarca { get; set; }
        public Nullable<int> SpecificationAttributeOptionId { get; set; }
    
        public virtual Fabricante Fabricante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioFisicoProducto> InventarioFisicoProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrecioAvisoCambio> PrecioAvisoCambio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
