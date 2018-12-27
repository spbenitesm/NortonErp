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
    
    public partial class Pagos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pagos()
        {
            this.FacturasPagos = new HashSet<FacturasPagos>();
        }
    
        public System.Guid PagoId { get; set; }
        public Nullable<System.Guid> ProveedorId { get; set; }
        public Nullable<System.Guid> PagoCuentaOrigen { get; set; }
        public Nullable<System.Guid> PagoCuentaDestino { get; set; }
        public Nullable<System.DateTime> PagoFecha { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.Guid> UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public Nullable<System.Guid> UsuarioActualizacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturasPagos> FacturasPagos { get; set; }
    }
}
