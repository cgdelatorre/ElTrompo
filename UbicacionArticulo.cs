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
    
    public partial class UbicacionArticulo
    {
        public string UbicacionId { get; set; }
        public int Orden { get; set; }
        public string ArticuloId { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
        public string AlmacenId { get; set; }
    
        public virtual Ubicacion Ubicacion { get; set; }
    }
}