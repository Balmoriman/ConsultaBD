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
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.CobranzaCliente = new HashSet<CobranzaCliente>();
            this.ControlFolioReparto = new HashSet<ControlFolioReparto>();
            this.EmpleadoDocumento = new HashSet<EmpleadoDocumento>();
            this.FuncionEmpleado = new HashSet<FuncionEmpleado>();
            this.InventarioFisicoEmpleado = new HashSet<InventarioFisicoEmpleado>();
            this.InventarioFisicoMarbeteHistorico = new HashSet<InventarioFisicoMarbeteHistorico>();
            this.InventarioFisicoMarbeteHistorico1 = new HashSet<InventarioFisicoMarbeteHistorico>();
            this.InventarioFisicoMarbeteRevision = new HashSet<InventarioFisicoMarbeteRevision>();
            this.InventarioFisicoMarbeteRevision1 = new HashSet<InventarioFisicoMarbeteRevision>();
            this.RegistroVisitantes = new HashSet<RegistroVisitantes>();
            this.SeccionProductoBitacora = new HashSet<SeccionProductoBitacora>();
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int ClaveEmpleado { get; set; }
        public int NumeroEmpleado { get; set; }
        public int ClaveSucursal { get; set; }
        public string NombreLargo { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<System.DateTime> FechaContratacion { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public string CuentaNomina { get; set; }
        public string LiteralesRFC { get; set; }
        public string NumerosRFC { get; set; }
        public string HomoclaveRFC { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public Nullable<int> ClaveCanalVenta { get; set; }
        public string SeguroSocial { get; set; }
        public string GrupoSanguineo { get; set; }
        public Nullable<System.Guid> Puesto_Id { get; set; }
        public Nullable<System.Guid> DOPuesto_Id { get; set; }
        public string Correo { get; set; }
        public string CorreoPersonal { get; set; }
        public string Localizacion { get; set; }
        public string CodigoS2K { get; set; }
        public bool Activo { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public Nullable<System.Guid> DOPuestoEspecifico_Id { get; set; }
        public string Extension { get; set; }
        public Nullable<long> plaza_especifico_id { get; set; }
    
        public virtual CanalVenta CanalVenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CobranzaCliente> CobranzaCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlFolioReparto> ControlFolioReparto { get; set; }
        public virtual Puesto Puesto { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoDocumento> EmpleadoDocumento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuncionEmpleado> FuncionEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioFisicoEmpleado> InventarioFisicoEmpleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioFisicoMarbeteHistorico> InventarioFisicoMarbeteHistorico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioFisicoMarbeteHistorico> InventarioFisicoMarbeteHistorico1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioFisicoMarbeteRevision> InventarioFisicoMarbeteRevision { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioFisicoMarbeteRevision> InventarioFisicoMarbeteRevision1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroVisitantes> RegistroVisitantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeccionProductoBitacora> SeccionProductoBitacora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}