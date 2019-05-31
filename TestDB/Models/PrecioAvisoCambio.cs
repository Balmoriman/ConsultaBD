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
    
    public partial class PrecioAvisoCambio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrecioAvisoCambio()
        {
            this.ProductoPrecioHistorico = new HashSet<ProductoPrecioHistorico>();
        }
    
        public System.Guid PrecioAvisoCambio_Id { get; set; }
        public string SerieAviso { get; set; }
        public int FolioAviso { get; set; }
        public int ClaveMarcaLinea { get; set; }
        public byte[] Archivo { get; set; }
        public int OpcEstatusAvisoCambio { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> UsuarioAplica { get; set; }
        public Nullable<System.DateTime> FechaAplica { get; set; }
        public Nullable<int> UsuarioAutoriza { get; set; }
        public Nullable<System.DateTime> FechaAutoriza { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual FabricanteMarcaLinea FabricanteMarcaLinea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoPrecioHistorico> ProductoPrecioHistorico { get; set; }
    }
}
