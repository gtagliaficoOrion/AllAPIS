using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class Response_cuentas
    {
        public string DueDate { get; set; }
        public string SubSociedad { get; set; }
        public string AcctName { get; set; }
        public decimal BalScCred { get; set; }
        public decimal BalScDeb { get; set; }
        public decimal Saldo { get; set; }
        public int Dias_vencido { get; set; }

    }
    public class ListaResponse : List<Response_cuentas>
    {

    }
}
