using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class M66006
    {

        [Key]
        public string CodImpuesto { get; set; }

        public decimal PorImpuesto { get; set; }

        public bool ValidVentas { get; set; }

        public bool ValidCompras { get; set; }
    }
}
