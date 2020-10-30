
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SopTecDLL.Entitites {
    [Table("Estados")]
    public class Estado {
        public int      id          { get; set; }
        public string   name        { get; set; }
        public int      dttos       { get; set; }
        public DateTime created     { get; set; }
        public bool     active      { get; set; }
        public List<Distrito>   
                        Distritos   { get; set; }
    } // -cls
} // -nsp
