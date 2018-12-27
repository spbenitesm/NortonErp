using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NortonMvc.Models;

namespace NortonMvc.Controllers
{
    public class FacturasController : Controller
    {
        private nortonEntities db = new nortonEntities();

        // GET: Facturas
        public ActionResult Index()
        {
            var facturas = db.Facturas.Include(f => f.TiposFactura);
            return View(facturas.ToList());
        }

        // GET: Facturas/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Factura factura = db.Facturas.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            return View(factura);
        }

        // GET: Facturas/Create
        public ActionResult Create()
        {
            ViewBag.FacturaTipo = new SelectList(db.TiposFacturas, "TipoFacturaId", "TipoFacturaCodigo");
            return View();
        }

        // POST: Facturas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FacturaId,FacturaProyecto,FacturaTipo,FacturaSerie,FacturaNumero,FacturaFechaEmision,FacturaFechaVencimiento,FacturaMoneda,FacturaEstado,FacturaSubtotal,FacturaIgv,FacturaImporteTotal,FacturaFondoGarantia,FacturaPorcentajeDetraccion,FacturaMontoDetraccion,FacturaImportePagar,FacturaUrl,FacturaFechaPagoProgramada")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                factura.FacturaId = Guid.NewGuid();
                db.Facturas.Add(factura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FacturaTipo = new SelectList(db.TiposFacturas, "TipoFacturaId", "TipoFacturaCodigo", factura.FacturaTipo);
            return View(factura);
        }

        // GET: Facturas/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Factura factura = db.Facturas.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            ViewBag.FacturaTipo = new SelectList(db.TiposFacturas, "TipoFacturaId", "TipoFacturaCodigo", factura.FacturaTipo);
            return View(factura);
        }

        // POST: Facturas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FacturaId,FacturaProyecto,FacturaTipo,FacturaSerie,FacturaNumero,FacturaFechaEmision,FacturaFechaVencimiento,FacturaMoneda,FacturaEstado,FacturaSubtotal,FacturaIgv,FacturaImporteTotal,FacturaFondoGarantia,FacturaPorcentajeDetraccion,FacturaMontoDetraccion,FacturaImportePagar,FacturaUrl,FacturaFechaPagoProgramada")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(factura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FacturaTipo = new SelectList(db.TiposFacturas, "TipoFacturaId", "TipoFacturaCodigo", factura.FacturaTipo);
            return View(factura);
        }

        // GET: Facturas/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Factura factura = db.Facturas.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            return View(factura);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Factura factura = db.Facturas.Find(id);
            db.Facturas.Remove(factura);
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
