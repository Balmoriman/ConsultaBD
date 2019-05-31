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
    
    public partial class DevolucionClienteProductoImporte
    {
        public System.Guid DevolucionCliente_Id { get; set; }
        public int NumeroPartidaOrigen { get; set; }
        public int ClaveTipoImporte { get; set; }
        public decimal ImporteIVAIncluido { get; set; }
        public decimal ImporteIVADesglosado { get; set; }
        public decimal Porcentaje { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual DevolucionClienteProducto DevolucionClienteProducto { get; set; }
        public virtual TipoImporte TipoImporte { get; set; }
    }
}
