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
    
    public partial class Linea
    {
        public string LineaId { get; set; }
        public string Nombre { get; set; }
        public double Puntuacion { get; set; }
        public double DiaSurtido { get; set; }
        public double DiaCaducidad { get; set; }
        public double MargenUtilidad { get; set; }
        public double MargenUtilidad2 { get; set; }
        public double MargenUtilidad3 { get; set; }
        public double MargenUtilidad4 { get; set; }
        public double MargenMinimo { get; set; }
        public double MargenMaximo { get; set; }
        public double PorceImpuesto { get; set; }
        public double PorceImpuesto2 { get; set; }
        public bool DescVtaCredito { get; set; }
        public bool ExcluyeOferta { get; set; }
        public double PorceComision { get; set; }
        public string CuentaContable { get; set; }
        public bool ImprimeCopia { get; set; }
        public double Copias { get; set; }
        public double AcumMerma { get; set; }
        public double TopeMerma { get; set; }
        public Nullable<System.DateTime> UltBorradoAcum { get; set; }
        public bool Desglose { get; set; }
        public double TipoCorte { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
        public string ImpuestoId { get; set; }
        public double IVA { get; set; }
        public string FormulaIdCosto { get; set; }
        public string FormulaIdPrecio { get; set; }
        public string MargenId { get; set; }
        public double IEPS { get; set; }
        public Nullable<int> CosteoId { get; set; }
        public Nullable<int> MetodoCambioPrecio { get; set; }
    }
}