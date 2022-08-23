using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class T41002
    {
        [Key]
        public int ID_T41002 { get; set; }
        public int ID_T41001 { get; set; }
        public int DocEntry { get; set; }
        public int SubSocieda { get; set; }

    }
}
