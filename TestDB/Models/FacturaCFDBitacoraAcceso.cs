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
    
    public partial class FacturaCFDBitacoraAcceso
    {
        public System.Guid FacturaCFD_Id { get; set; }
        public System.DateTime FechaAcceso { get; set; }
        public int ClaveSucursal { get; set; }
        public int ClaveMedio { get; set; }
        public Nullable<System.Guid> BitacoraFacturaCFD_Id { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual FacturaClienteCFD FacturaClienteCFD { get; set; }
    }
}
