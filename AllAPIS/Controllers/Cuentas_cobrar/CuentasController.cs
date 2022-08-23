using AllAPIS.Context;
using AllAPIS.Entities;
using AllAPIS.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Controllers.Cuentas_cobrar
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentasController : ControllerBase
    {
        private readonly CuentasDbContext context;
        private readonly ApiCantDbContext contextAPI;
        Helpers helpers;
        ListaResponse response;



        public CuentasController(CuentasDbContext context, ApiCantDbContext contextAPI)
        {
            this.context = context;
            helpers = new Helpers(context, contextAPI);
        }

        // GET api/<CobrarController1>/5
        [HttpGet("{id}")]
        public ListaResponse Get(string id)
        {
            response = helpers.CuentasPorCobrar(id);

            try
            {
                if (response != null)
                {
                    return response;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            return response;
        }
    }
}
