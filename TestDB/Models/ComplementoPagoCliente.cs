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
    
    public partial class ComplementoPagoCliente
    {
        public System.Guid ComplementoPagoClienteId { get; set; }
        public string SerieComplementoPagoCliente { get; set; }
        public int FolioComplementoPagoCliente { get; set; }
    
        public virtual FacturaClienteCFD FacturaClienteCFD { get; set; }
    }
}
