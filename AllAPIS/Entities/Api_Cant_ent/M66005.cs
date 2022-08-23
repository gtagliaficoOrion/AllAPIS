using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class M66005
    {  
        [Key]
        public string CodArt { get; set; }

        public string CodBarra { get; set; }

        public string CodAlterno { get; set; }

        public string Descripcion { get; set; }

        public string CodImpuesto { get; set; }
    }
}
