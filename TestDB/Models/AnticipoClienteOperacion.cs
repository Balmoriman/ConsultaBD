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
    
    public partial class AnticipoClienteOperacion
    {
        public int Id { get; set; }
        public System.Guid AnticipoClienteId { get; set; }
        public int Operacion_Id { get; set; }
        public string Datos { get; set; }
        public int Estatus { get; set; }
        public int row_version { get; set; }
    }
}
