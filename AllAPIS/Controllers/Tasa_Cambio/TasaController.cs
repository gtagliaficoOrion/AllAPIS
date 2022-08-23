using AllAPIS.Entities;
using AllAPIS.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasaController : ControllerBase
    {
        Logics logics = new Logics(); 
        RespuestaTasa jsonrecibido;
        // GET api/values
        [HttpGet]
        public async Task<RespuestaTasa> GetAsync()
        {
            jsonrecibido = await logics.GetRecibidoAsync();

            return jsonrecibido;
        }
    }
}
