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
    
    public partial class MovimientoCheque
    {
        public System.Guid MovimientoCheque_Id { get; set; }
        public System.Guid Cheque_Id { get; set; }
        public int ClaveMotivoMovimientoCheque { get; set; }
        public int ClaveSucursal { get; set; }
        public decimal Importe { get; set; }
        public Nullable<System.Guid> SesionCaja_Id { get; set; }
        public string Observaciones { get; set; }
        public string Deposito { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Cheque Cheque { get; set; }
        public virtual MotivoMovimientoCheque MotivoMovimientoCheque { get; set; }
    }
}
