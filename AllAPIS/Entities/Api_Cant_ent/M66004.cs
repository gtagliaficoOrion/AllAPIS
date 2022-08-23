using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class M66004
    {
        [Key]
        public int ID_M66004 { get; set; }
        public string codAlmacen { get; set; } 
         
        public string Descripcion { get; set; }

        public int CodGrupoSocio { get; set; }

    }
}
