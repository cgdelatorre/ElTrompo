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
    
    public partial class Existencia
    {
        public string ArticuloId { get; set; }
        public string AlmacenId { get; set; }
        public int Tipo { get; set; }
        public Nullable<double> UniInicial { get; set; }
        public Nullable<double> UniCotiza { get; set; }
        public Nullable<double> UniCompra { get; set; }
        public Nullable<double> UniDevVenta { get; set; }
        public Nullable<double> UniTraEntrada { get; set; }
        public Nullable<double> UniVenta { get; set; }
        public Nullable<double> UniDevCom { get; set; }
        public Nullable<double> UniTraSalida { get; set; }
        public Nullable<double> UniAjusteEntrada { get; set; }
        public Nullable<double> UniAjusteSalida { get; set; }
        public Nullable<double> UniProducEntrada { get; set; }
        public Nullable<double> UniProducSalida { get; set; }
        public Nullable<double> UniMerma { get; set; }
        public Nullable<double> UniPromocion { get; set; }
        public Nullable<double> UniPedido { get; set; }
        public Nullable<double> UniPedCompra { get; set; }
        public Nullable<double> UniPedVenta { get; set; }
        public Nullable<double> UniReferencia { get; set; }
        public Nullable<double> UniMinima { get; set; }
        public Nullable<double> UniMaxima { get; set; }
        public Nullable<double> UniPorRecibir { get; set; }
        public Nullable<System.DateTime> UltimaVenta { get; set; }
        public Nullable<System.DateTime> UltimaCompra { get; set; }
        public Nullable<System.DateTime> UltimoInventario { get; set; }
        public Nullable<System.DateTime> UltimoPrePublico { get; set; }
        public Nullable<System.DateTime> UltimoPedido { get; set; }
        public Nullable<System.DateTime> UltimaGenMaxMin { get; set; }
        public Nullable<System.DateTime> UltimaTransferencia { get; set; }
        public Nullable<double> DiaMaximo { get; set; }
        public string Estatus { get; set; }
        public string Ubicacion { get; set; }
        public Nullable<double> Demanda { get; set; }
        public string CategoriaArticulo { get; set; }
        public Nullable<System.DateTime> UltimaCategorizacion { get; set; }
        public Nullable<System.DateTime> Fechahora { get; set; }
        public Nullable<System.DateTime> FechaHoraServer { get; set; }
        public Nullable<double> ExistenciaEmpaque { get; set; }
    }
}
