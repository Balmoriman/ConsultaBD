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
    
    public partial class InventarioFisicoUsuario
    {
        public System.Guid InventarioFisicoEmpleado_Id { get; set; }
        public int ClaveUsuario { get; set; }
        public Nullable<System.Guid> PerfilOriginal_Id { get; set; }
        public Nullable<int> ClaveSucursalOrigen { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual InventarioFisicoEmpleado InventarioFisicoEmpleado { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
