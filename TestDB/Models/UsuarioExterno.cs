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
    
    public partial class UsuarioExterno
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> Cliente_Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Nombre2 { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombreLargo { get; set; }
        public Nullable<int> TipoSolicitud { get; set; }
        public Nullable<int> ClaveTipoUsuario { get; set; }
        public Nullable<int> ClaveTipoColaborador { get; set; }
        public Nullable<int> ClaveCondicionVenta { get; set; }
        public Nullable<int> ClaveVendedor { get; set; }
        public Nullable<int> Estatus { get; set; }
        public string CodigoConfirmacion { get; set; }
        public Nullable<bool> CreditoAutorizado { get; set; }
        public Nullable<decimal> LimiteCredito { get; set; }
        public Nullable<decimal> LimiteCreditoPorcentaje { get; set; }
        public Nullable<int> ClaveCanal { get; set; }
        public Nullable<System.DateTime> FechaUltimaCompraApp { get; set; }
        public Nullable<System.DateTime> FechaUltimoAcceso { get; set; }
        public Nullable<int> UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioAutoriza { get; set; }
        public Nullable<System.DateTime> FechaAutoriza { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    }
}
