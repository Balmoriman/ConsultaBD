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
    
    public partial class ControlEventoFolioAsignado
    {
        public System.Guid EventoDetalle_Id { get; set; }
        public System.Guid BloqueFolio_Id { get; set; }
        public int FolioAsignado { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
    
        public virtual ControlEventoDetalle ControlEventoDetalle { get; set; }
        public virtual ControlEventoFolio ControlEventoFolio { get; set; }
    }
}
