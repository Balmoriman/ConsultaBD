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
    
    public partial class BitacoraCorreccion
    {
        public System.Guid Correccion_Id { get; set; }
        public string Ticket { get; set; }
        public int TipoTicket { get; set; }
        public string Descripcion { get; set; }
        public string Solución { get; set; }
        public Nullable<int> CheckInTF { get; set; }
        public string UsuarioCorrige { get; set; }
        public System.DateTime FechaAlta { get; set; }
    }
}
