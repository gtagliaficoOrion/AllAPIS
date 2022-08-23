using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class M64001
    {
        [Key]
        public int ID_M64001 { get; set; }
        public string CardCode { get; set; }
        public char CardType { get; set; }
        public string CardName { get; set; }
        public string CodGrupoSocio { get; set; }
    }
}
