//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElTrompo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Promocion
    {
        public string EmpresaId { get; set; }
        public string SucursalId { get; set; }
        public string Prefijo { get; set; }
        public string ArticuloId { get; set; }
        public string FolioInicial { get; set; }
        public string FolioFinal { get; set; }
        public Nullable<System.DateTime> FechaInicial { get; set; }
        public Nullable<System.DateTime> FechaFinal { get; set; }
        public Nullable<double> VentaMinima { get; set; }
        public int Tipo { get; set; }
        public string TipoPromo { get; set; }
        public int Criterio { get; set; }
        public Nullable<double> Importe { get; set; }
        public Nullable<double> Porcentaje { get; set; }
        public string MonedaId { get; set; }
        public string Descripcion { get; set; }
        public string RutaImagen { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
    }
}