using Norton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace Norton.Extensiones
{
    public static class Extensiones
    {
        static Guid guid;
        public static void AgregarSeleccione(this List<ParametrosDetalle> lista)
        {
            lista.Insert(
                0,
                new ParametrosDetalle
                {
                    ParametroDetalleId = guid,
                    ParametroDetalleDescripcion = "--Seleccione--"
                });
        }
        
    }
}