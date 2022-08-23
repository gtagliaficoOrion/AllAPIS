using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class T41001
    {
        [Key]
        public int CardCode { get; set; }
        public string CardName { get; set; }
        public int ID_T41001 { get; set; }
        public int SubSociedad { get; set; }
    }
}
