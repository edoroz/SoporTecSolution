
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SopTecDLL.Entitites {
    [Table("Modulos")]
    public class Modulo {                   [Display(Name = "Id")]
        public int  Id      { get; set; }   [Display(Name = "Módulo")]
        public byte Name    { get; set; }   [Display(Name = "Topología")]
        public byte Topo    { get; set; }
        //public Tipo Tipos    { get; set; }
    } // -cls
} // -nsp
