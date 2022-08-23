using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class M10012
    {
        [Key]
        public int ID_M10012 { get; set; }
        public string Address { get; set; }

        public string SubSociedad { get; set; }

    }
}
