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
    
    public partial class Turno
    {
        public string EmpresaId { get; set; }
        public string SucursalId { get; set; }
        public string EstacionId { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public int Turno1 { get; set; }
        public bool TurnoActivo { get; set; }
        public string UsuarioId { get; set; }
        public string EmpleadoId { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
    }
}