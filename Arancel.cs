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
    
    public partial class Arancel
    {
        public string ArticuloId { get; set; }
        public string FraccionId { get; set; }
        public string Excepcion { get; set; }
        public string PaisOrigen { get; set; }
        public Nullable<double> PorceArancel { get; set; }
        public Nullable<double> PorceAplicacion { get; set; }
        public Nullable<int> Orden { get; set; }
        public string Region { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
    }
}
