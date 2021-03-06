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
    
    public partial class Operacion
    {
        public string OperacionId { get; set; }
        public string Nombre { get; set; }
        public string OperacionIdAnterior { get; set; }
        public string CuentaContable { get; set; }
        public string ArregloConceptoId { get; set; }
        public string ClaveConcepto { get; set; }
        public string ArregloOperacionIdRelacionado { get; set; }
        public string ClaveOperacion { get; set; }
        public string ColectorIdPredeterminado { get; set; }
        public string InterfaseCierre { get; set; }
        public string InterfaseApertura { get; set; }
        public string Observacion { get; set; }
        public int EntradaSalida { get; set; }
        public int FactorEfectivo { get; set; }
        public int DesgloseCorte { get; set; }
        public int OrdenImpresion { get; set; }
        public int CopiaTicket { get; set; }
        public int RequierePassword { get; set; }
        public bool TransmiteOperacion { get; set; }
        public bool AutoAgregaOperacion { get; set; }
        public bool AfectaInventario { get; set; }
        public bool ObligaObservacion { get; set; }
        public bool Activa { get; set; }
        public bool GeneraTransaccion { get; set; }
        public bool RequiereMovimiento { get; set; }
        public bool DivideDocumento { get; set; }
        public bool RequiereComision { get; set; }
        public bool InventarioReal { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
        public string MovimientoX { get; set; }
        public string MovimientoZ { get; set; }
        public string ResumenX { get; set; }
        public string ResumenZ { get; set; }
        public string Reporte { get; set; }
        public string ConceptoPredeterminado { get; set; }
        public Nullable<bool> RequiereAdministrador { get; set; }
        public Nullable<bool> EnviaNotificacion { get; set; }
        public Nullable<bool> EnviaCorreoElectronico { get; set; }
    }
}
