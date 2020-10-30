using SopTecDLL.Entitites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SopTecDLL.Context {
    public class SopTecContext : DbContext {
            public DbSet<Estado>    Estados     { get; set; }
            public DbSet<Distrito>  Distritos   { get; set; }
            public DbSet<Modulo>    Modulos     { get; set; }

            public SopTecContext() : base() {
                Database.SetInitializer(new DataBaseInitializer());
            } // -cns

        } // -cls
    } // -nsp
