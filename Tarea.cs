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
    
    public partial class Tarea
    {
        public string TareaId { get; set; }
        public string Nombre { get; set; }
        public string taridtare { get; set; }
        public string Tipo { get; set; }
        public string Parametro { get; set; }
        public Nullable<System.DateTime> FechaIni { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<int> Repeticion { get; set; }
        public string HorDia { get; set; }
        public string DiaSemana { get; set; }
        public Nullable<int> Estatus { get; set; }
        public byte[] UltimoMovimiento { get; set; }
        public string OrigenUsuario { get; set; }
        public string UsuarioIdDestino { get; set; }
        public string UsuarioIdOrigen { get; set; }
        public string EstacionIdDestino { get; set; }
        public string Respuesta { get; set; }
        public string DocumentoIdRelacion { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaServidor { get; set; }
        public Nullable<int> TurnoId { get; set; }
        public Nullable<int> Sincronia { get; set; }
        public Nullable<System.DateTime> FechaControl { get; set; }
    }
}
