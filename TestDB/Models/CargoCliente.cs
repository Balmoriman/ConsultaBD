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
    
    public partial class CargoCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CargoCliente()
        {
            this.CargoClienteImportes = new HashSet<CargoClienteImportes>();
            this.NotaCargo = new HashSet<NotaCargo>();
        }
    
        public System.Guid CargoCliente_Id { get; set; }
        public int ClaveSucursal { get; set; }
        public string SerieCargo { get; set; }
        public int FolioCargo { get; set; }
        public int ClaveTipoCargoCliente { get; set; }
        public System.Guid Cliente_Id { get; set; }
        public Nullable<int> SucursalDocumentoReferencia { get; set; }
        public Nullable<int> ClaveDocumentoReferencia { get; set; }
        public Nullable<int> ClaveBanco { get; set; }
        public int ClaveTipoMoneda { get; set; }
        public int ClaveTipoCambio { get; set; }
        public decimal ValorTipoCambio { get; set; }
        public Nullable<int> NumeroDocumento { get; set; }
        public string ConceptoCargoCliente { get; set; }
        public string NotasCargoCliente { get; set; }
        public int OpcEstatusCargo { get; set; }
        public Nullable<int> UsuarioCancela { get; set; }
        public Nullable<System.DateTime> FechaCancela { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Banco Banco { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual TipoCambio TipoCambio { get; set; }
        public virtual TipoCargoCliente TipoCargoCliente { get; set; }
        public virtual TipoMoneda TipoMoneda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargoClienteImportes> CargoClienteImportes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCargo> NotaCargo { get; set; }
    }
}