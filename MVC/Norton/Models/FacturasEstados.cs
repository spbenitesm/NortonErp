//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Norton.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacturasEstados
    {
        public System.Guid FacturaEstadoId { get; set; }
        public string FacturaEstadoEstado { get; set; }
        public Nullable<System.Guid> FacturaId { get; set; }
        public Nullable<System.DateTime> FacturaEstadoFecha { get; set; }
        public Nullable<System.Guid> FacturaEstadoUsuario { get; set; }
        public string FacturaEstadoMotivosRechazo { get; set; }
        public string FacturaEstadoObservaciones { get; set; }
    
        public virtual Facturas Facturas { get; set; }
    }
}
