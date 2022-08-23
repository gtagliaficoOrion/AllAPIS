using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class Response_cant
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
    }
}
