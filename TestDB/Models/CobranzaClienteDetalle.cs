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
    
    public partial class CobranzaClienteDetalle
    {
        public System.Guid CobranzaClienteId { get; set; }
        public int ClaveCobranzaDetalle { get; set; }
        public System.Guid CuentaCobrarCliente_Id { get; set; }
        public int OpcEstatusCobranza { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual CobranzaCliente CobranzaCliente { get; set; }
        public virtual CuentaCobrarCliente CuentaCobrarCliente { get; set; }
        public virtual EstatusCobranza EstatusCobranza { get; set; }
    }
}
