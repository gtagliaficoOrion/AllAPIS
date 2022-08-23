using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class T69003
    {

        [Key]
        public int ID_T69003 { get; set; }

        public string CodArt { get; set; }

        public decimal Existencia { get; set; }

        public string CodAlmacen { get; set; }

        public string SubSociedad { get; set; }


    }
}
