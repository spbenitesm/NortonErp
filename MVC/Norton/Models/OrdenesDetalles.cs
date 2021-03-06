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
    using System.ComponentModel;

    public partial class OrdenesDetalles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenesDetalles()
        {
            this.OrdenesPartidas = new HashSet<OrdenesPartidas>();
        }
    
        public System.Guid OrdenDetalleId { get; set; }
        public Nullable<System.Guid> OrdenId { get; set; }
        [DisplayName("Item")]
        public Nullable<int> OrdenDetalleItem { get; set; }
        [DisplayName("Descripcion")]
        public string OrdenDetalleDescripcion { get; set; }
        [DisplayName("Cuotas")]
        public Nullable<int> OrdenDetalleCuotas { get; set; }
        [DisplayName("Unidad")]
        public string OrdenDetalleUnidad { get; set; }
        [DisplayName("Precio Unitario")]
        public Nullable<decimal> OrdenDetallePrecioUnitario { get; set; }
        [DisplayName("Precio Total")]
        public Nullable<decimal> OrdenDetallePrecioTotal { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.Guid> UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public Nullable<System.Guid> UsuarioActualizacion { get; set; }
    
        public virtual Ordenes Ordenes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenesPartidas> OrdenesPartidas { get; set; }
    }
}
