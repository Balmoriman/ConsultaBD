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
    
    public partial class SesionBitacoraActividad
    {
        public System.Guid SesionAccion_Id { get; set; }
        public System.Guid Bitacora_Id { get; set; }
        public string Accion { get; set; }
        public string Descripcion { get; set; }
        public int Resultado { get; set; }
        public System.DateTime FechaAlta { get; set; }
    
        public virtual SesionBitacora SesionBitacora { get; set; }
    }
}
