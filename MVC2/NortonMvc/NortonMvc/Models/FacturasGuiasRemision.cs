//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NortonMvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacturasGuiasRemision
    {
        public System.Guid FacturaGuiaRemisionId { get; set; }
        public Nullable<System.Guid> FacturaId { get; set; }
        public string FacturaGuiaRemisionSerie { get; set; }
        public string FacturaGuiaRemisionNumero { get; set; }
        public Nullable<System.DateTime> FacturaGuiaRemisionFechaEmision { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.Guid> UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public Nullable<System.Guid> UsuarioActualizacion { get; set; }
    
        public virtual Factura Factura { get; set; }
    }
}
