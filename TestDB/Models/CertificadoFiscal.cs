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
    
    public partial class CertificadoFiscal
    {
        public string SerieCertificado { get; set; }
        public int ClaveSucursal { get; set; }
        public string LlavePrivada { get; set; }
        public byte[] Certificado { get; set; }
        public byte[] Pfx { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaCaducidad { get; set; }
        public Nullable<int> UsuarioAutoriza { get; set; }
        public Nullable<System.DateTime> FechaAutoriza { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int UsuarioAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public int Estatus { get; set; }
    }
}
