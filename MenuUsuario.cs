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
    
    public partial class MenuUsuario
    {
        public string UsuarioId { get; set; }
        public string MenuId { get; set; }
        public double Orden { get; set; }
        public string CategoriaId { get; set; }
        public string Titulo { get; set; }
        public Nullable<byte> Predeterminado { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
    
        public virtual MenuElemento MenuElemento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}