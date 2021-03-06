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
    
    public partial class SeccionProductoBitacora
    {
        public System.Guid SeccionProducto_Id { get; set; }
        public int FolioRegistroBitacora { get; set; }
        public int ClaveTipoMovimientoInventario { get; set; }
        public System.Guid SucursalAlmacenSeccionOrigen_Id { get; set; }
        public Nullable<System.Guid> SucursalAlmacenSeccionDestino_Id { get; set; }
        public Nullable<System.Guid> InventarioUbicacion_Id { get; set; }
        public int ExistenciaOperacion { get; set; }
        public int ExistenciaSeccion { get; set; }
        public int Cantidad { get; set; }
        public int SaldoSeccion { get; set; }
        public int ClaveEmpleadoSolicita { get; set; }
        public Nullable<System.DateTime> FechaOperacion { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual InventarioUbicacion InventarioUbicacion { get; set; }
        public virtual SeccionProducto SeccionProducto { get; set; }
        public virtual SucursalAlmacenSeccion SucursalAlmacenSeccion { get; set; }
        public virtual SucursalAlmacenSeccion SucursalAlmacenSeccion1 { get; set; }
    }
}
