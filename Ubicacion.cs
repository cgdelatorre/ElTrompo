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
    
    public partial class Ubicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ubicacion()
        {
            this.UbicacionArticuloes = new HashSet<UbicacionArticulo>();
        }
    
        public string UbicacionId { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public string ArchivoJPG { get; set; }
        public string PixelInicioX { get; set; }
        public string PixelInicioY { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
        public string AlmacenId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionArticulo> UbicacionArticuloes { get; set; }
    }
}
