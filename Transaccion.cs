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
    
    public partial class Transaccion
    {
        public string TransaccionId { get; set; }
        public string DocumentoId { get; set; }
        public string Descripcion { get; set; }
        public string ClaveId { get; set; }
        public string VendedorId { get; set; }
        public string EmpresaId { get; set; }
        public string AlmacenId { get; set; }
        public string SucursalId { get; set; }
        public string OperacionId { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
    }
}