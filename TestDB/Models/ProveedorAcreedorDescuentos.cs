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
    
    public partial class ProveedorAcreedorDescuentos
    {
        public System.Guid ProveedorAcreedor_Id { get; set; }
        public decimal DC1 { get; set; }
        public decimal DC2 { get; set; }
        public decimal DC3 { get; set; }
        public decimal DC4 { get; set; }
        public decimal DC5 { get; set; }
        public decimal DC6 { get; set; }
        public decimal DC7 { get; set; }
        public decimal DF1 { get; set; }
        public int DiasDF1 { get; set; }
        public decimal DF2 { get; set; }
        public int DiasDF2 { get; set; }
        public decimal DF3 { get; set; }
        public int DiasDF3 { get; set; }
        public decimal DF4 { get; set; }
        public int DiasDF4 { get; set; }
        public decimal DF5 { get; set; }
        public int DiasDF5 { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual ProveedorAcreedor ProveedorAcreedor { get; set; }
    }
}
