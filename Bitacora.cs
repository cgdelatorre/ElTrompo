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
    
    public partial class Bitacora
    {
        public int BitacoraId { get; set; }
        public string TipoElemento { get; set; }
        public string Afectado { get; set; }
        public string Llave { get; set; }
        public string TipoCambio { get; set; }
        public string UsuarioId { get; set; }
        public string EstacionId { get; set; }
        public Nullable<System.DateTime> FechaHoraModificacion { get; set; }
        public string RegistroCambio { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
    }
}
