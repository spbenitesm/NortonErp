using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class Factura
    {
        public string Codigo { get; set; }
        public int ContactoId { get; set; }
        public List<FacturaDetalle> Detalles { get; set; }
        public int FacturaId { get; set; }
        public DateTime Fecha { get; set; }
        public int FormaPagoId { get; set; }
        public double Igv { get; set; }
        public string LugarEntrega { get; set; }
        public int PlazoEntrega { get; set; }
        public int ProveedorId { get; set; }
        public int TipoId { get; set; }
        public double Total { get; set; }
    }
}
