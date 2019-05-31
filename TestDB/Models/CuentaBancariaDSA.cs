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
    
    public partial class CuentaBancariaDSA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuentaBancariaDSA()
        {
            this.ClienteAvisoPago = new HashSet<ClienteAvisoPago>();
            this.CuentaBancariaDSA1 = new HashSet<CuentaBancariaDSA>();
            this.CuentaBancariaDSAMarcador = new HashSet<CuentaBancariaDSAMarcador>();
            this.CuentaXPagarFactoraje = new HashSet<CuentaXPagarFactoraje>();
            this.MovimientoBanco = new HashSet<MovimientoBanco>();
            this.MovimientosBancos = new HashSet<MovimientosBancos>();
            this.ProcesoPagoCxPPaquete = new HashSet<ProcesoPagoCxPPaquete>();
        }
    
        public System.Guid CuentaBancariaDSA_Id { get; set; }
        public int FolioMovimientoBanco { get; set; }
        public int FolioImportacion { get; set; }
        public int FolioConciliacion { get; set; }
        public Nullable<System.Guid> CuentaBancariaBase_Id { get; set; }
        public Nullable<System.Guid> ProveedorAcreedor_Id { get; set; }
        public int ClaveBanco { get; set; }
        public string SucursalCuenta { get; set; }
        public string Cuenta { get; set; }
        public string CLABE { get; set; }
        public int ClaveTipoMoneda { get; set; }
        public string Observaciones { get; set; }
        public int Estatus { get; set; }
        public decimal FactorCambiario { get; set; }
        public System.DateTime FechaTipoCambio { get; set; }
        public decimal ImporteSaldo { get; set; }
        public decimal ImporteDisponible { get; set; }
        public decimal ImporteCredito { get; set; }
        public int ClaveTipoCuenta { get; set; }
        public int AplicaTransferencia { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Banco Banco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteAvisoPago> ClienteAvisoPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaBancariaDSA> CuentaBancariaDSA1 { get; set; }
        public virtual CuentaBancariaDSA CuentaBancariaDSA2 { get; set; }
        public virtual ProveedorAcreedor ProveedorAcreedor { get; set; }
        public virtual TipoMoneda TipoMoneda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaBancariaDSAMarcador> CuentaBancariaDSAMarcador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaXPagarFactoraje> CuentaXPagarFactoraje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimientoBanco> MovimientoBanco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimientosBancos> MovimientosBancos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcesoPagoCxPPaquete> ProcesoPagoCxPPaquete { get; set; }
    }
}
