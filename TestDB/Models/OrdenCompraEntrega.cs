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
    
    public partial class OrdenCompraEntrega
    {
        public System.Guid OrdenCompraEntrega_Id { get; set; }
        public System.Guid OrdenCompraId { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public System.TimeSpan HoraInicio { get; set; }
        public System.TimeSpan HoraFinal { get; set; }
        public int ClaveSucursal { get; set; }
        public int Bahia { get; set; }
        public int EstatusEntrega { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<byte> Estatus { get; set; }
        public Nullable<byte> OrigenCaptura { get; set; }
    
        public virtual OrdenCompra OrdenCompra { get; set; }
    }
}
