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
    
    public partial class ProduccionMovimiento
    {
        public long ID { get; set; }
        public int Batch { get; set; }
        public string EmpresaId { get; set; }
        public string SucursalId { get; set; }
        public string OperacionId { get; set; }
        public string Folio { get; set; }
        public Nullable<int> RenglonId { get; set; }
        public string AlmacenId { get; set; }
        public string ArticuloId { get; set; }
        public Nullable<double> Unidad { get; set; }
        public string UsuarioId { get; set; }
        public string DispositivoId { get; set; }
        public string Ubicacion { get; set; }
        public string Estatus { get; set; }
        public Nullable<System.DateTime> FechaHoraCaptura { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
        public string ExpresionRegular { get; set; }
        public Nullable<double> UnidadPlaneada { get; set; }
    }
}
