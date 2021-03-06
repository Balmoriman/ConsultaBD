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
    
    public partial class RegistroVisitantes
    {
        public System.Guid RegistroVisitantes_Id { get; set; }
        public int FolioRegistro { get; set; }
        public int ClaveSucursal { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string NombreVisitante { get; set; }
        public string PersonaVisitada { get; set; }
        public string Empresa { get; set; }
        public System.DateTime FechaEntrada { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public int Estatus { get; set; }
        public string Asunto { get; set; }
        public int NumeroGafete { get; set; }
        public string Notas { get; set; }
        public int ClaveEmpleado { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
