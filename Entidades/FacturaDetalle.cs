using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class FacturaDetalle
    {
        public FacturaDetalle()
        {
            Identificador = Guid.NewGuid().ToString();
        }
        public string CentroCosto { get; set; }
        public string Item { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public int Cuotas { get; set; }
        public int Unidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double PrecioTotal { get; set; }
        public string Identificador { get; set; }
    }
}
