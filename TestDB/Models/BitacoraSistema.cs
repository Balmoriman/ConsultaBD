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
    
    public partial class BitacoraSistema
    {
        public System.Guid BitacoraSistema_Id { get; set; }
        public string CodigoUsuario { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }
        public string ChangedColumns { get; set; }
        public string NombreMaquina { get; set; }
        public string Actions { get; set; }
        public Nullable<System.Guid> UsuarioSesion_Id { get; set; }
        public string Programa { get; set; }
        public string Funcion { get; set; }
        public string Tabla { get; set; }
        public string Datos { get; set; }
        public System.DateTime FechaAlta { get; set; }
    }
}
