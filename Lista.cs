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
    
    public partial class Lista
    {
        public int ListaId { get; set; }
        public string UsuarioWeb { get; set; }
        public string PasswordWeb { get; set; }
        public string ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
    }
}
