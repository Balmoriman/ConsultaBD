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
    
    public partial class ProductoNegadoCatalogo
    {
        public int ClaveProductoNegadoCatalogo { get; set; }
        public int ClaveSucursalProductoNegadoCatalogo { get; set; }
        public System.Guid Cliente_Id { get; set; }
        public Nullable<int> ClaveArticulo { get; set; }
        public Nullable<int> ClaveMarcaLinea { get; set; }
        public int ClaveEstatusProductoNegado { get; set; }
        public int CantidadSolicitada { get; set; }
        public Nullable<int> CantidadExistencia { get; set; }
        public int CantidadNegada { get; set; }
        public int ExistenciaMinima { get; set; }
        public int ExistenciaMaxima { get; set; }
        public string GrupoVentaABC { get; set; }
        public Nullable<int> UsuarioNego { get; set; }
        public Nullable<System.DateTime> FechaNego { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
        public Nullable<int> ClaveTipoMonedaOrigen { get; set; }
        public Nullable<int> ClaveTipoMonedaDestino { get; set; }
        public Nullable<decimal> FactorTipoCambio { get; set; }
        public string Nota { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual EstatusProductoNegado EstatusProductoNegado { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
