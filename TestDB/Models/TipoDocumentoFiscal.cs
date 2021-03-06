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
    
    public partial class TipoDocumentoFiscal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoDocumentoFiscal()
        {
            this.ClienteAddenda = new HashSet<ClienteAddenda>();
            this.CuentaCobrarCliente = new HashSet<CuentaCobrarCliente>();
            this.FacturaClienteCFD = new HashSet<FacturaClienteCFD>();
            this.FolioFiscal = new HashSet<FolioFiscal>();
            this.NotaCredito = new HashSet<NotaCredito>();
            this.PagoCliente = new HashSet<PagoCliente>();
        }
    
        public string CodigoDocumentoFiscal { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int UsuarioAlta { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteAddenda> ClienteAddenda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaCobrarCliente> CuentaCobrarCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaClienteCFD> FacturaClienteCFD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FolioFiscal> FolioFiscal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCredito> NotaCredito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoCliente> PagoCliente { get; set; }
    }
}
