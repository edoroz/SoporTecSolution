
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SopTecDLL;
using SopTecDLL.Entitites;

namespace SoporTecSon.Controllers
{
    public class EstadoController : Controller {
        //private SopTecContext db = new SopTecContext();
        private readonly IRepository<Estado> _edoRep = new DLLFacade().GetEstadoRepo();

        [HttpGet]
        public ActionResult Index() {
            return View(_edoRep.Read());
        }

        [HttpGet]
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado estado = _edoRep.Read(id.Value);
            if (estado == null) {
                return HttpNotFound();
            }
            return View(estado);
        }

        [HttpGet]
        public ActionResult Create() {
            ViewBag.Edos = new SelectList(_edoRep.Read().Where(x => x.active == true), "Id", "Name");
            return View();
        }

        [HttpPost]  [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,dttos,created,active")] Estado estado) {
            if (ModelState.IsValid) {
                _edoRep.Create(estado);
                return RedirectToAction("Index");
            }

            return View(estado);
        }

        [HttpGet]
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado estado = _edoRep.Read(id.Value);
            if (estado == null)
            {
                return HttpNotFound();
            }
            return View(estado);
        }
        
        [HttpPost]  [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,dttos,created,active")] Estado estado) {
            if (ModelState.IsValid) {
                _edoRep.Update(estado);
                return RedirectToAction("Index");
            }
            return View(estado);
        }

        [HttpGet]
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado estado = _edoRep.Read(id.Value);
            if (estado == null) {
                return HttpNotFound();
            }
            return View(estado);
        }

        [HttpPost]  [ActionName("Delete")]   [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            _edoRep.Delete(id);
            return RedirectToAction("Index");
        }
        
    } // -cls
} // -nsp
