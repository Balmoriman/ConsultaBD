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
    
    public partial class TipoMovimientoCuentaPorCobrar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoMovimientoCuentaPorCobrar()
        {
            this.CuentaCobrarCliente = new HashSet<CuentaCobrarCliente>();
            this.CuentaCobrarClienteMovimiento = new HashSet<CuentaCobrarClienteMovimiento>();
            this.PagoCliente = new HashSet<PagoCliente>();
            this.PagoCobranza = new HashSet<PagoCobranza>();
        }
    
        public int ClaveTipoMovimientoCuentaPorCobrar { get; set; }
        public string Nombre { get; set; }
        public string CodigoCxC { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public int TipoOperacionCargo { get; set; }
        public int TipoOperacionAbono { get; set; }
        public int TipoOperacionComision { get; set; }
        public bool Pago { get; set; }
        public string Tipo { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int UsuarioAlta { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaCobrarCliente> CuentaCobrarCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentaCobrarClienteMovimiento> CuentaCobrarClienteMovimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoCliente> PagoCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoCobranza> PagoCobranza { get; set; }
    }
}