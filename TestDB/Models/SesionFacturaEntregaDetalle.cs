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
    
    public partial class SesionFacturaEntregaDetalle
    {
        public System.Guid Entrega_Id { get; set; }
        public System.Guid FacturaCliente_Id { get; set; }
        public int opcEstatusEntrega { get; set; }
        public string Observaciones { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int UsuarioAlta { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
    
        public virtual FacturaCliente FacturaCliente { get; set; }
        public virtual SesionFacturaEntrega SesionFacturaEntrega { get; set; }
    }
}
