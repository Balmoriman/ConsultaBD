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
    
    public partial class ProcesoTipoDocumentoDigitalizacion
    {
        public System.Guid ProcesoTipoDocumentoDigitalizacionId { get; set; }
        public System.Guid ProcesoId { get; set; }
        public System.Guid TipoDocumentoDigitalizacionId { get; set; }
        public int Estatus { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Proceso Proceso { get; set; }
        public virtual TipoDocumentoDigitalizacion TipoDocumentoDigitalizacion { get; set; }
    }
}
