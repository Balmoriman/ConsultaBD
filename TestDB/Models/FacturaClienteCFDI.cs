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
    
    public partial class FacturaClienteCFDI
    {
        public System.Guid FacturaCFD_Id { get; set; }
        public Nullable<System.Guid> TimbradoProveedor_Id { get; set; }
        public Nullable<System.Guid> FolioSAT { get; set; }
        public int ClaveEstatus { get; set; }
        public Nullable<System.DateTime> FechaTimbrado { get; set; }
    
        public virtual FacturaClienteCFD FacturaClienteCFD { get; set; }
        public virtual TimbradoProveedor TimbradoProveedor { get; set; }
    }
}
