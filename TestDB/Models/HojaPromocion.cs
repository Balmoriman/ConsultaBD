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
    
    public partial class HojaPromocion
    {
        public int Clave { get; set; }
        public string Codigo { get; set; }
        public string Item { get; set; }
        public string Marca { get; set; }
        public string GpoVenta { get; set; }
        public string Descripcion1 { get; set; }
        public string CodFabrica { get; set; }
        public string Sucursal { get; set; }
        public string Sucursal1 { get; set; }
        public string Nombre { get; set; }
        public string Descripción2 { get; set; }
        public Nullable<System.DateTime> Vigencia { get; set; }
        public Nullable<System.DateTime> Hasta { get; set; }
        public string Canal { get; set; }
        public string Aplica_Comisión { get; set; }
        public Nullable<double> Descuento_Promoción { get; set; }
        public Nullable<double> Cantidad_Minima_por_Operación { get; set; }
        public Nullable<double> Cantidad_Maxima_por_Operación { get; set; }
        public Nullable<double> Cantidad_Promoción { get; set; }
        public string Aplica_descuento_operación { get; set; }
        public string Aplica_promesa_de_Compra { get; set; }
    }
}
