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
    
    public partial class Direccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Direccion()
        {
            this.ProveedorAcreedor = new HashSet<ProveedorAcreedor>();
            this.ProveedorAcreedorDireccion = new HashSet<ProveedorAcreedorDireccion>();
        }
    
        public System.Guid Direccion_Id { get; set; }
        public short ClaveTipoVialidad { get; set; }
        public string Calle { get; set; }
        public string NumeroExterno { get; set; }
        public string NumeroInterno { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Pais { get; set; }
        public string EntreCalles { get; set; }
        public string Observacion { get; set; }
        public string CodigoPostal { get; set; }
        public byte[] SHA1 { get; set; }
        public Nullable<System.Guid> SEPOMEX_Id { get; set; }
    
        public virtual TipoVialidad TipoVialidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProveedorAcreedor> ProveedorAcreedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProveedorAcreedorDireccion> ProveedorAcreedorDireccion { get; set; }
    }
}