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
    
    public partial class ArticuloDescripcionPlantilla
    {
        public System.Guid ArticuloDescripcionPlantilla_Id { get; set; }
        public string Nombre { get; set; }
        public string Plantilla { get; set; }
        public string ClaveProductoSegmento2 { get; set; }
        public string ClaveProductoSegmento1 { get; set; }
        public int UsuarioAlta { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual ProductoSegmento2 ProductoSegmento2 { get; set; }
    }
}
