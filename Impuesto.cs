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
    
    public partial class Impuesto
    {
        public string ImpuestoId { get; set; }
        public string ZonaId { get; set; }
        public string Nombre { get; set; }
        public double Aplica1 { get; set; }
        public double Porcentaje1 { get; set; }
        public double Aplica2 { get; set; }
        public double Porcentaje2 { get; set; }
        public double Aplica3 { get; set; }
        public double Porcentaje3 { get; set; }
        public double Aplica4 { get; set; }
        public double Porcentaje4 { get; set; }
        public bool RecalculaArticulo { get; set; }
        public string Cuota { get; set; }
        public string Enlace { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
        public Nullable<bool> AfectaMovimiento1 { get; set; }
        public Nullable<bool> AfectaMovimiento2 { get; set; }
        public Nullable<bool> AfectaMovimiento3 { get; set; }
        public string Base1 { get; set; }
        public string Base2 { get; set; }
        public string Base3 { get; set; }
        public string ArticuloBase1 { get; set; }
        public string ArticuloBase2 { get; set; }
        public string ArticuloBase3 { get; set; }
    }
}