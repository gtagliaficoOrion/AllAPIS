using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class Producto
    {
        [Key]
        public string CodArt { get; set; }

        public string Descripcion { get; set; }
        
        public decimal Existencia { get; set; }

        public string SubSociedad { get; set; }

        public string Almacen { get; set; }


    }

    public class ListaProductos : List<Producto>
    {

    }
}
