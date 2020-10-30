
using SopTecDLL.Entitites;
using SopTecDLL.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SopTecDLL
{
    public class DLLFacade {
        public IRepository<Estado> GetEstadoRepo() {
            return new EstadosRepository();
        }

        public IRepository<Distrito> GetDistritoRepo() {
            return new DistritosRepository();
        }

        public IRepository<Modulo> GetModuloRepo() {
            return new ModulosRepository();
        }
        
        public byte GetEstations() {
            //List<byte> estNo = null;
            //estNo.Add(16);
            return 21;
        }
             
    } // -cls
} // -nsp
