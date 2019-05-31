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
    
    public partial class ControlFolioReparto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ControlFolioReparto()
        {
            this.ControlFolioRepartoDetalle = new HashSet<ControlFolioRepartoDetalle>();
        }
    
        public System.Guid ControlFolioReparto_Id { get; set; }
        public string SerieReparto { get; set; }
        public int FolioReparto { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public int ClaveEstatusEntrega { get; set; }
        public int ClaveVehiculo { get; set; }
        public int ClaveSucursalRutaReparto { get; set; }
        public int ClaveTipoRutaReparto { get; set; }
        public int ClaveEmpleado { get; set; }
        public bool Activo { get; set; }
        public Nullable<int> UsuarioCancela { get; set; }
        public Nullable<System.DateTime> FechaCancela { get; set; }
        public string AuxiliarChofer { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual EstatusEntrega EstatusEntrega { get; set; }
        public virtual RutaRepartoSucursal RutaRepartoSucursal { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlFolioRepartoDetalle> ControlFolioRepartoDetalle { get; set; }
    }
}