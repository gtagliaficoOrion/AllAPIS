using AllAPIS.Context;
using AllAPIS.Entities;
using AllAPIS.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Controllers.Api_Cant
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiCantController : ControllerBase
    {
        private readonly ApiCantDbContext context;
        Functions functions;
        ListaProductos oProducto;
        Response_cant response;

        public ApiCantController(ApiCantDbContext context)
        {
            this.context = context;
            functions = new Functions(context);
        }


        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public ListaProductos Get(string id)
        {
            oProducto = functions.BuscarCantidadProducto(id);

            try
            {
                if (oProducto != null)
                {
                    return oProducto;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            return oProducto;

        }

    }
}
