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
    
    public partial class TimbradoProveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimbradoProveedor()
        {
            this.FacturaClienteCFDI = new HashSet<FacturaClienteCFDI>();
            this.TimbradoDocumento = new HashSet<TimbradoDocumento>();
            this.TimbradoProveedorFolios = new HashSet<TimbradoProveedorFolios>();
        }
    
        public System.Guid TimbradoProveedor_Id { get; set; }
        public string Nombre { get; set; }
        public int ClaveTipoContrato { get; set; }
        public string WebService { get; set; }
        public string UsuarioWS { get; set; }
        public string PasswordWS { get; set; }
        public int PrioridadServicio { get; set; }
        public int EstatusServicio { get; set; }
        public int Estatus { get; set; }
        public int SaldoTimbres { get; set; }
        public int FolioMinimo { get; set; }
        public int AvisoPeriodo { get; set; }
        public string ClaseBase { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaClienteCFDI> FacturaClienteCFDI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimbradoDocumento> TimbradoDocumento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimbradoProveedorFolios> TimbradoProveedorFolios { get; set; }
    }
}
