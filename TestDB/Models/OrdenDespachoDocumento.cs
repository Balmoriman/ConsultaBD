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
    
    public partial class OrdenDespachoDocumento
    {
        public System.Guid OrdenDespachoDocumentoId { get; set; }
        public Nullable<System.Guid> OrdenDespachoId { get; set; }
        public int ClaveOrdenDespachoSucursal { get; set; }
        public int ClaveOrdenDespacho { get; set; }
        public int ClaveTipoDocumentoODD { get; set; }
        public string Descripcion { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Archivo { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
    
        public virtual OrdenDespacho OrdenDespacho { get; set; }
        public virtual TipoDocumentoODD TipoDocumentoODD { get; set; }
    }
}
