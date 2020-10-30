
using SopTecDLL.Context;
using SopTecDLL.Entitites;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SopTecDLL.Repositories {
    internal class DistritosRepository : AbstracRepository<Distrito> {
        protected override void Create(SopTecContext db, Distrito t) {
            db.Distritos.Add(t);
        }

        protected override Distrito Read(SopTecContext db, int id) {
            return db.Distritos.FirstOrDefault(x => x.id == id);
        }

        protected override List<Distrito> Read(SopTecContext db) {
            return db.Distritos.ToList();
        }

        protected override void Update(SopTecContext db, Distrito t) {
            db.Entry(t).State = EntityState.Modified;
        }

        protected override void Delete(SopTecContext db, int id) {
            db.Entry(Read(id)).State = EntityState.Deleted;
        }

    } // -cls
} // -nsp
