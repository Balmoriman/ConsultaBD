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
    
    public partial class InventarioUbicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventarioUbicacion()
        {
            this.ProductoIdentificadorCorte = new HashSet<ProductoIdentificadorCorte>();
            this.SeccionProductoBitacora = new HashSet<SeccionProductoBitacora>();
            this.SeccionProductoUbicacion = new HashSet<SeccionProductoUbicacion>();
        }
    
        public System.Guid InventarioUbicacion_Id { get; set; }
        public System.Guid SucursalAlmacenSeccion_Id { get; set; }
        public string CodigoUbicacion { get; set; }
        public string Rack { get; set; }
        public int Division { get; set; }
        public int Nivel { get; set; }
        public int Estatus { get; set; }
        public int ClaveTipoUbicacion { get; set; }
        public int EsTrameria { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public decimal Frente { get; set; }
        public decimal Fondo { get; set; }
        public decimal Altura { get; set; }
    
        public virtual SucursalAlmacenSeccion SucursalAlmacenSeccion { get; set; }
        public virtual TipoUbicacion TipoUbicacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoIdentificadorCorte> ProductoIdentificadorCorte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeccionProductoBitacora> SeccionProductoBitacora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeccionProductoUbicacion> SeccionProductoUbicacion { get; set; }
    }
}
