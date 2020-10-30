
using SopTecDLL.Context;
using SopTecDLL.Entitites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SopTecDLL.Repositories {
    internal class ModulosRepository : AbstracRepository<Modulo> {
        protected override void Create(SopTecContext db, Modulo t) {
            db.Modulos.Add(t);
        }

        protected override Modulo Read(SopTecContext db, int id) {
            return db.Modulos.FirstOrDefault(x => x.Id == id);
        }

        protected override List<Modulo> Read(SopTecContext db) {
            return db.Modulos.ToList();
        }

        protected override void Update(SopTecContext db, Modulo t) {
            db.Entry(t).State = EntityState.Modified;
        }

        protected override void Delete(SopTecContext db, int id) {
            db.Entry(Read(db, id)).State = EntityState.Deleted;
        }
    } // -cls
} // nsp
