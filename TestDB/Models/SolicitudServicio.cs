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
    
    public partial class SolicitudServicio
    {
        public System.Guid SolicitudServicio_Id { get; set; }
        public int ClaveTipoServicio { get; set; }
        public string Parametros { get; set; }
        public System.Guid UsuarioSesionSolicita_Id { get; set; }
        public Nullable<System.Guid> UsuarioSesionResuelve_Id { get; set; }
        public int Estatus { get; set; }
        public string Resultado { get; set; }
        public int Reintentos { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual TipoServicio TipoServicio { get; set; }
        public virtual UsuarioSesion UsuarioSesion { get; set; }
        public virtual UsuarioSesion UsuarioSesion1 { get; set; }
    }
}