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
    
    public partial class CuentaXPagarComprobante
    {
        public System.Guid CuentaPorPagar_Id { get; set; }
        public System.Guid DocumentoFiscal_Id { get; set; }
        public int ClaveTipoDocumento { get; set; }
        public string Descripcion { get; set; }
        public string NombreArchivo { get; set; }
        public int DS { get; set; }
        public int Estatus { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string EmisorRFC { get; set; }
        public string ReceptorRFC { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<System.Guid> UUID { get; set; }
        public string Sello { get; set; }
    
        public virtual CuentaXPagar CuentaXPagar { get; set; }
    }
}
