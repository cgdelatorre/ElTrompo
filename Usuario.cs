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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.MenuUsuarios = new HashSet<MenuUsuario>();
            this.PermisoUsuarios = new HashSet<PermisoUsuario>();
        }
    
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string EmpresaId { get; set; }
        public string Mail { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public string VendedorId { get; set; }
        public byte[] HuellaDigital { get; set; }
        public string Imagen { get; set; }
        public Nullable<decimal> Perfil { get; set; }
        public string Telefono { get; set; }
        public string Extension { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
        public Nullable<int> NIP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuUsuario> MenuUsuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermisoUsuario> PermisoUsuarios { get; set; }
    }
}
