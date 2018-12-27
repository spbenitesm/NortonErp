using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto
        {
            get
            {
                return string.Format("{0} {1}, {2}", ApellidoPaterno, ApellidoMaterno, Nombre);
            }
        }
    }
}
