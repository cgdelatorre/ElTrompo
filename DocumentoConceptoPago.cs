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
    
    public partial class DocumentoConceptoPago
    {
        public string DocumentoId { get; set; }
        public string ConceptoId { get; set; }
        public string ReferenciaPago { get; set; }
        public double Importe { get; set; }
        public double Recibido { get; set; }
        public string MonedaId { get; set; }
        public double TipoCambio { get; set; }
        public Nullable<System.DateTime> FechaDocumento { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
    }
}