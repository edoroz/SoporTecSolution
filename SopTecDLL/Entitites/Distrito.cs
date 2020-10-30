
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SopTecDLL.Entitites {
    [Table("Distritos")]
    public class Distrito {
        public int      id          { get; set; }   [Display (Name ="Sede")]
        public string   name        { get; set; }   [Display (Name ="Estado")]  [ForeignKey("estado")]
        public int      edo_id      { get; set; }
        public Estado   estado      { get; set; }   [Display (Name ="Distrito")]
        public string   dtto        { get; set; }   [Display (Name ="Vocal Ejecutivo")]
        public string   voc_ejec    { get; set; }   [Display (Name ="Vocal Registro")]
        public string   voc_reg     { get; set; }   [Display (Name ="Creado")]
        public DateTime created     { get; set; }   [Display (Name ="Activo")]
        public bool     active      { get; set; }

    } // -cls
} // -nsp
