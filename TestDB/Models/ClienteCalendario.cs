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
    
    public partial class ClienteCalendario
    {
        public System.Guid Calendario_Id { get; set; }
        public System.Guid Cliente_Id { get; set; }
        public Nullable<System.Guid> ClienteDireccion_Id { get; set; }
        public short ClaveTipoCalendario { get; set; }
        public int SemanaDia { get; set; }
        public string Horario { get; set; }
        public string DiasMes { get; set; }
        public string Notas { get; set; }
        public bool Activo { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual ClienteDireccion ClienteDireccion { get; set; }
        public virtual TipoCalendario TipoCalendario { get; set; }
    }
}
