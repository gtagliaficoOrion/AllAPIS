using AllAPIS.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AllAPIS.Logic
{
    public class Logics
    {
        public async Task<RespuestaTasa> GetRecibidoAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://s3.amazonaws.com/dolartoday/data.json");
            HttpResponseMessage response = await client.GetAsync("https://s3.amazonaws.com/dolartoday/data.json");

            var json = await response.Content.ReadAsStringAsync();
            var Tasas = JsonConvert.DeserializeObject<RecibidoTasa>(json);


            RespuestaTasa respuesta = new RespuestaTasa();

            respuesta.promedio_USD = Tasas.USD.promedio;
            respuesta.promedio_real_USD = Tasas.USD.promedio_real;
            respuesta.promedio_EUR = Tasas.EUR.promedio;
            respuesta.promedio_real_EUR = Tasas.EUR.promedio_real;

            return respuesta;
        }
    }
}
