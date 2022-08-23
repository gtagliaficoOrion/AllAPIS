using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class T41003
    {
        [Key]
        public int ID_T41003 { get; set; }
        public string CodPago { get; set; }
        public string NombrePago { get; set; }

    }
}
