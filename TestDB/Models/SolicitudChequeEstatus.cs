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
    
    public partial class SolicitudChequeEstatus
    {
        public System.Guid SolicitudCheque_Id { get; set; }
        public int ClaveSolicitudChequeEstatus { get; set; }
        public System.DateTime FechaCambioEstatus { get; set; }
        public int UsuarioModifica { get; set; }
        public System.DateTime FechaModifica { get; set; }
    
        public virtual ClienteSolicitudCheque ClienteSolicitudCheque { get; set; }
        public virtual SolicitudChequeSeguimientoEstatus SolicitudChequeSeguimientoEstatus { get; set; }
    }
}
