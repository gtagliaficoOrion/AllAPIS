using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class T62003
    {
        [Key]
        public int ID_T62003 { get; set; }
        public string ShortName { get; set; }
        public decimal Debit { get; set; }
        public string TransType { get; set; }
        public decimal Credit { get; set; }
        public string Origen { get; set; }
        public string AcctName { get; set; }
        public DateTime DueDate { get; set; }
        public int ID_T62004 { get; set; }
        public string SubSociedad { get; set; }
        public decimal BalScDeb { get; set; }
        public decimal BalSysCred { get; set; }
        public decimal BalScCred { get; set; }
        public decimal BalSysDeb { get; set; }
        public decimal SYSDeb { get; set; }
        public decimal SYSCred { get; set; }
    }
}
