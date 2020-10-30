
using SopTecDLL.Context;
using SopTecDLL.Entitites;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SopTecDLL.Repositories {
    internal class EstadosRepository : AbstracRepository<Estado> {
        protected override void Create(SopTecContext db, Estado t) {
            db.Estados.Add(t);
        }

        protected override Estado Read(SopTecContext db, int id) {
            return db.Estados.FirstOrDefault(x => x.id == id);
        }

        protected override List<Estado> Read(SopTecContext db) {
            return db.Estados.ToList();
        }

        protected override void Update(SopTecContext db, Estado t) {
            db.Entry(t).State = EntityState.Modified;
        }

        protected override void Delete(SopTecContext db, int id) {
            db.Entry(Read(id)).State = EntityState.Deleted;
        }
    } // -cls
} // -nsp
