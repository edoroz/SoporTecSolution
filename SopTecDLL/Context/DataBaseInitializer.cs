using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SopTecDLL.Entitites;

namespace SopTecDLL.Context {
    internal class DataBaseInitializer : DropCreateDatabaseIfModelChanges<SopTecContext> {
        protected override void Seed(SopTecContext db) {
            db.Estados.Add(new Estado() {id =  1, name = "Aguascalientes",      dttos = 3, active = true , created = DateTime.Now });
            db.Estados.Add(new Estado() {id =  2, name = "Baja California",     dttos = 8, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id =  3, name = "Baja California Sur", dttos = 2, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id =  4, name = "Campeche",            dttos = 2, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id =  5, name = "Coahuila",            dttos = 7, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id =  6, name = "Colima",              dttos = 2, active = true , created = DateTime.Now });
            db.Estados.Add(new Estado() {id =  7, name = "Chiapas",             dttos =13, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id =  8, name = "Chihuahua",           dttos = 9, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id =  9, name = "Cd. de Mexico",       dttos =24, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 10, name = "Durango",             dttos = 4, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 11, name = "Guanajuato",          dttos =15, active = true , created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 12, name = "Guerrero",            dttos = 9, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 13, name = "Hidalgo",             dttos = 7, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 14, name = "Jalisco",             dttos =20, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 15, name = "Mexico",              dttos =41, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 16, name = "Michoacan",           dttos =12, active = true , created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 17, name = "Morelos",             dttos = 5, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 18, name = "Nayarit",             dttos = 3, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 19, name = "Nuevo Leon",          dttos =12, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 20, name = "Oaxaca",              dttos =10, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 21, name = "Puebla",              dttos =15, active = true , created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 22, name = "Queretaro",           dttos = 5, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 23, name = "Quintana Roo",        dttos = 4, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 24, name = "San Luis Potosí",     dttos = 7, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 25, name = "Sinaloa"  ,           dttos = 7, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 26, name = "Sonora"   ,           dttos = 7, active =  true, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 27, name = "Tabasco"   ,          dttos = 6, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 28, name = "Tamaulipas" ,         dttos = 9, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 29, name = "Tlaxcala"   ,         dttos = 3, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 30, name = "Veracruz"   ,         dttos =20, active = false, created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 31, name = "Yucatán",             dttos = 5, active = true , created = DateTime.Now });
            db.Estados.Add(new Estado() {id = 32, name = "Zacatecas"   ,        dttos = 4, active = false, created = DateTime.Now });
            
            base.Seed(db);
        }
    } // -cls
} // -nsp
