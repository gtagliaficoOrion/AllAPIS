using AllAPIS.Context;
using AllAPIS.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Logic
{
    public class Helpers
    {
            string path = @"Token.json";
            private readonly CuentasDbContext context;
        private readonly ApiCantDbContext contextApi;
            public ListaResponse responses = new ListaResponse();
            public Helpers(CuentasDbContext context, ApiCantDbContext contextApi)
            {
                this.context = context;
                this.contextApi = contextApi;
            }

            public ListaResponse CuentasPorCobrar(string Id_ciente)
            {

                var oM64001 = context.M64001.FirstOrDefault(p => p.CardCode == Id_ciente);
                var oT62003 = context.T62003.Where(p => (p.ShortName == oM64001.CardCode) && (p.TransType == "13") && (p.Origen == "VTA")).ToList();

                foreach (var item in oT62003)
                {
                    var oM10012 = context.M10012.FirstOrDefault(p => (p.SubSociedad == item.SubSociedad));
                    Response_cuentas r = new Response_cuentas();
                    DateTime today = DateTime.Today;
                    r.AcctName = item.AcctName;
                    r.BalScCred = item.BalSysCred;
                    r.BalScDeb = item.BalSysDeb;
                    r.DueDate = item.DueDate.ToString();
                    TimeSpan difFechas = today - item.DueDate;
                    r.SubSociedad = oM10012.Address;
                    r.Saldo = (item.BalSysDeb - item.BalSysCred);
                    r.Dias_vencido = difFechas.Days;
                    if (r.Saldo > 0)
                    {
                        responses.Add(r);
                    }
                }

                string result = JsonConvert.SerializeObject(responses);
                return responses;
            }
        }
}
