using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Norton.Models;
using Norton.Extensiones;

namespace Norton.Controllers
{
    public class OrdenesController : Controller
    {
        private nortonEntities db = new nortonEntities();

        // GET: Ordenes
        public ActionResult Index()
        {
            var ordenes = db.Ordenes.Include(o => o.Proveedores);
            return View(ordenes.ToList());
        }

        // GET: Ordenes/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ordenes ordenes = db.Ordenes.Find(id);
            if (ordenes == null)
            {
                return HttpNotFound();
            }
            return View(ordenes);
        }

        // GET: Ordenes/Create
        public ActionResult Create()
        {
            var tipos = db.ParametrosDetalle.Where(x => x.Parametros.ParametroCodigo == "01").ToList();
            var formaPago = db.ParametrosDetalle.Where(x => x.Parametros.ParametroCodigo == "02").ToList();
            var proveedores = db.Proveedores;

            ViewBag.OrdenContactoInterno = new SelectList(new List<ProveedoresContactos>(), "ProveedorContactoId", "ProveedorContactoApellidos");
            ViewBag.OrdenFormaPago = new SelectList(formaPago, "ParametroDetalleId", "ParametroDetalleDescripcion");
            ViewBag.OrdenTipo = new SelectList(tipos, "ParametroDetalleId", "ParametroDetalleDescripcion");
            ViewBag.OrdenProveedor = new SelectList(proveedores, "ProveedorId", "ProveedorRazonSocial");
            return View(new Ordenes());
        }
        public JsonResult ObtenerContactos(Guid ProveedorId)
        {
            var query = from contacto in db.ProveedoresContactos
                            /*join usuario in db.Usuarios
                            on contacto.UsuarioId equals usuario.UsuarioId*/
                        where contacto.ProveedorId == ProveedorId
                        select new
                        {
                            contacto.ProveedorContactoId,
                            Nombres = contacto.ProveedorContactoNombres,
                            Apellidos = contacto.ProveedorContactoApellidos
                        };
            var contactos = query.ToList().Select(x => new
            {
                x.ProveedorContactoId,
                Nombres = $"{x.Apellidos}, {x.Nombres}"
            }).ToList();
            contactos.Insert(0, new
            {
                ProveedorContactoId = new Guid(),
                Nombres = "--Selecione--"
            });
            var entrega = new SelectList(contactos, "ProveedorContactoId", "Nombres");
            return Json(entrega);
        }

        // POST: Ordenes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrdenId,OrdenCodigo,OrdenTipo,OrdenFecha,OrdenProveedor,OrdenSubtotal,OrdenIgv,OrdenTotal,OrdenPlazoEntrega,OrdenFormaPago,OrdenContactoInterno,OrdenLugarEntrega,OrdenEstado,OrdenObservacion,OrdenMotivoRechazo")] Ordenes ordenes)
        {
            if (ModelState.IsValid)
            {
                ordenes.OrdenId = Guid.NewGuid();
                db.Ordenes.Add(ordenes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrdenProveedor = new SelectList(db.Proveedores, "ProveedorId", "ProveedorRuc", ordenes.OrdenProveedor);
            return View(ordenes);
        }

        // GET: Ordenes/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ordenes ordenes = db.Ordenes.Find(id);
            if (ordenes == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrdenProveedor = new SelectList(db.Proveedores, "ProveedorId", "ProveedorRuc", ordenes.OrdenProveedor);
            return View(ordenes);
        }

        // POST: Ordenes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrdenId,OrdenCodigo,OrdenTipo,OrdenFecha,OrdenProveedor,OrdenSubtotal,OrdenIgv,OrdenTotal,OrdenPlazoEntrega,OrdenFormaPago,OrdenContactoInterno,OrdenLugarEntrega,OrdenEstado,OrdenObservacion,OrdenMotivoRechazo")] Ordenes ordenes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ordenes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrdenProveedor = new SelectList(db.Proveedores, "ProveedorId", "ProveedorRuc", ordenes.OrdenProveedor);
            return View(ordenes);
        }

        // GET: Ordenes/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ordenes ordenes = db.Ordenes.Find(id);
            if (ordenes == null)
            {
                return HttpNotFound();
            }
            return View(ordenes);
        }

        // POST: Ordenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Ordenes ordenes = db.Ordenes.Find(id);
            db.Ordenes.Remove(ordenes);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
