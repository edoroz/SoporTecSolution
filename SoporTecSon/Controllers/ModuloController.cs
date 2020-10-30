
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SopTecDLL;
using SopTecDLL.Entitites;

namespace SoporTecSon.Controllers
{
    public class ModuloController : Controller {
        //private SopTecContext db = new SopTecContext();
        private readonly IRepository<Modulo>_modRep = new DLLFacade().GetModuloRepo();
        private readonly byte         _estNum = new DLLFacade().GetEstations();

        [HttpGet]
        public ActionResult Index() {
            return View(_modRep.Read());
        }

        [HttpGet]
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo modulo = _modRep.Read(id.Value);
            if (modulo == null) {
                return HttpNotFound();
            }
            return View(modulo);
        }

        [HttpGet]
        public ActionResult Create() {
            ViewBag.estaciones = Enumerable.Range(0, _estNum);
            //ViewBag.estaciones = new SelectList(_estNum , "Id", "Name");
            return View();
        }

        [HttpPost]  [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Topo")] Modulo modulo) {
            if (ModelState.IsValid) {
                _modRep.Create(modulo);
                return RedirectToAction("Index");
            }
            return View(modulo);
        }

        [HttpGet]
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo modulo = _modRep.Read(id.Value);
            if (modulo == null)
            {
                return HttpNotFound();
            }
            return View(modulo);
        }

        [HttpPost]  [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Topo")] Modulo modulo) {
            if (ModelState.IsValid) {
                _modRep.Update(modulo);

                return RedirectToAction("Index");
            }
            return View(modulo);
        }

        [HttpGet]
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo modulo = _modRep.Read(id.Value);
            if (modulo == null) {
                return HttpNotFound();
            }
            return View(modulo);
        }

        // POST: Modulo/Delete/5
        [HttpPost]  [ActionName("Delete")]  [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            _modRep.Delete(id);
            return RedirectToAction("Index");
        }

    } // -cls
} // -nsp
