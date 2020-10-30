
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SopTecDLL;
using SopTecDLL.Entitites;

namespace SoporTecSon.Controllers
{
    public class DistritoController : Controller {
        //private SopTecContext db = new SopTecContext();
        private readonly IRepository<Estado>    _edoRep = new DLLFacade().GetEstadoRepo();
        private readonly IRepository<Distrito>  _dtoRep = new DLLFacade().GetDistritoRepo();

        [HttpGet]
        public ActionResult Index() {
            //ViewBag.edo_id = new SelectList(_edoRep.Read().Where(x => x.active == true), "Id", "Name"); // Repeat on create
            ViewBag.estado = _edoRep.Read().FirstOrDefault(x =>x.active== true).name;
            return View(_dtoRep.Read());
        }

        [HttpGet]
        public ActionResult Details(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = _dtoRep.Read(id.Value);
            if(distrito == null) {
                return HttpNotFound();
            }
            return View(distrito);
        }

        [HttpGet]
        public ActionResult Create() {
            ViewBag.edo_id = new SelectList(_edoRep.Read().Where(x => x.active == true), "Id", "Name");
            return View();
        }

        [HttpPost] [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,edo_id,dtto,voc_ejec,voc_reg,created,active")] Distrito distrito) {
            if(ModelState.IsValid) {
                try {
                    _dtoRep.Create(distrito);
                    return RedirectToAction("Index");
                } catch(Exception e) {
                    //
                    return RedirectToAction("Index");
                }
            }
            return View(distrito);
        }

        [HttpGet]
        public ActionResult Edit(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = _dtoRep.Read(id.Value);
            if(distrito == null) {
                return HttpNotFound();
            }
            return View(distrito);
        }

        [HttpPost] [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,edo_id,dtto,voc_ejec,voc_reg,created,active")] Distrito distrito) {
            if(ModelState.IsValid) {
                _dtoRep.Update(distrito);
                return RedirectToAction("Index");
            }
            return View(distrito);
        }

        [HttpGet]
        public ActionResult Delete(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = _dtoRep.Read(id.Value);
            if(distrito == null) {
                return HttpNotFound();
            }
            return View(distrito);
        }

        [HttpPost]  [ActionName("Delete")]  [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            _dtoRep.Delete(id);
            return RedirectToAction("Index");
        }

    } // -cls
} // -nsp
