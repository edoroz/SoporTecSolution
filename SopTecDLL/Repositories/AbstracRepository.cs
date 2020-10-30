
using SopTecDLL.Context;
using System.Collections.Generic;

namespace SopTecDLL.Repositories
{
    internal abstract class AbstracRepository<T> : IRepository<T> {
        public T Create(T t) {
            using (SopTecContext db = new SopTecContext()) {
                Create(db, t);
                db.SaveChanges();
            } // Close Db Connection
            return t;
        }
        protected abstract void Create(SopTecContext db, T t);

        public T Read(int id) {
            using(SopTecContext db = new SopTecContext()) {
                return Read(db, id);
            } // Close Db Connection
        }
        protected abstract T Read(SopTecContext db, int id);

        public List<T> Read() {
            using(SopTecContext db = new SopTecContext()) {
                return Read(db);
            } // Close Db Connection
        }
        protected abstract List<T> Read(SopTecContext db);

        public T Update(T t) {
            using(SopTecContext db = new SopTecContext()) {
                Update(db, t);
                db.SaveChanges();
            } // Close Db Connection
            return t;
        }
        protected abstract void Update(SopTecContext db, T t);

        public bool Delete(int id) {
            if(Read(id) == null) {
                return false;
            }
            using(SopTecContext db = new SopTecContext()) {
                Delete(db, id);
                db.SaveChanges();
            } // Close Db Connection
            return Read(id) == null;
        }
        protected abstract void Delete(SopTecContext db, int id);
    } // -cls

    public class Xyz {
        
    }
} // -nsp

