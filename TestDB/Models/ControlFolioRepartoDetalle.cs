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
    
    public partial class ControlFolioRepartoDetalle
    {
        public System.Guid ControlFolioRepartoDetalle_Id { get; set; }
        public System.Guid ControlFolioReparto_Id { get; set; }
        public Nullable<System.Guid> OrdenDespachoId { get; set; }
        public int ClaveOrdenDespachoSucursalReparto { get; set; }
        public int ClaveOrdenDespachoReparto { get; set; }
        public Nullable<int> ClaveEstatusEntrega { get; set; }
        public Nullable<System.DateTime> FechaEnvio { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public Nullable<int> Orden { get; set; }
        public Nullable<System.DateTime> HoraInicioEntrega { get; set; }
        public Nullable<System.DateTime> HoraFinEntrega { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual ControlFolioReparto ControlFolioReparto { get; set; }
        public virtual EstatusEntrega EstatusEntrega { get; set; }
        public virtual OrdenDespachoReparto OrdenDespachoReparto { get; set; }
    }
}
