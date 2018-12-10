using NortonMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NortonMvc.Controllers
{
    public class OrdenController : Controller
    {
        private nortonEntities db = new nortonEntities();
        private Ordene Orden
        {
            get
            {
                if (Session["Orden"] == null)
                {
                    Session.Add("Orden", new Ordene());
                }
                return (Ordene)Session["Orden"];
            }
            set
            {
                Session["Orden"] = value;
            }
        }
        // GET: Orden
        public ActionResult Index()
        {
            var tipos = db.ParametrosDetalles.Where(x => x.Parametro.ParametroCodigo == "01").ToList();
            var formaPago = db.ParametrosDetalles.Where(x => x.Parametro.ParametroCodigo == "02").ToList();
            var proveedores = db.Proveedores;

            ViewBag.OrdenContactoInterno = new SelectList(new List<ProveedoresContacto>(), "ProveedorContactoId", "ProveedorContactoApellidos");
            ViewBag.OrdenFormaPago = new SelectList(formaPago, "ParametroDetalleId", "ParametroDetalleDescripcion");
            ViewBag.OrdenTipo = new SelectList(tipos, "ParametroDetalleId", "ParametroDetalleDescripcion");
            ViewBag.OrdenProveedor = new SelectList(proveedores, "ProveedorId", "ProveedorRazonSocial");
            //return View(new Ordene());
            return View("Crear");
        }
        [HttpPost]
        public ActionResult GuardarDetalle(OrdenesDetalle detalle)
        {
            if (Orden.OrdenesDetalles == null)
            { Orden.OrdenesDetalles = new List<OrdenesDetalle>(); }
            Orden.OrdenesDetalles.Add(detalle);

            return PartialView("_ListaDetalle", Orden.OrdenesDetalles);
        }
        public ActionResult Edit(Guid id)
        {
            var detalle = Orden.OrdenesDetalles.FirstOrDefault(x => x.OrdenDetalleId == id);
            return PartialView("_CrearDetalle", detalle);
        }
    }
}