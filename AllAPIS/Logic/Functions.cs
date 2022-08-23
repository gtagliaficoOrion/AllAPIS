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
    public class Functions
    {
            public ListaProductos ListaProd = new ListaProductos();
            private readonly ApiCantDbContext context;
            string path = @"Token.json";

            public Functions(ApiCantDbContext context)
            {
                this.context = context;
            }

            public ListaProductos BuscarCantidadProducto(string codigo)
            {

                var oM66005 = context.M66005.FirstOrDefault(p => p.CodBarra == codigo || p.CodArt == codigo || p.CodAlterno == codigo);
                var oT69003 = context.T69003.Where(p => p.CodArt == oM66005.CodArt).ToList();
                foreach (var item in oT69003)
                {
                    Producto oProducto = new Producto();
                    if (oM66005 != null)
                    {

                        var oM10012 = context.M10012.FirstOrDefault(p => p.SubSociedad == item.SubSociedad);
                        var oM66004 = context.M66004.FirstOrDefault(p => p.codAlmacen == item.CodAlmacen);

                        oProducto.CodArt = oM66005.CodArt;
                        oProducto.Descripcion = oM66005.Descripcion;
                        oProducto.SubSociedad = oM10012.Address;
                        oProducto.Existencia = item.Existencia;
                        oProducto.Almacen = oM66004.Descripcion;

                        ListaProd.Add(oProducto);
                    }
                }


                return ListaProd;
            }
            public bool ValidarToken(string token)
            {
                bool response = false;
                string key;

                using (StreamReader jsonStream = File.OpenText(path))
                {
                    var json = jsonStream.ReadToEnd();
                    Token oToken = JsonConvert.DeserializeObject<Token>(json);
                    key = oToken.Key;
                }

                if (token == key)
                {
                    response = true;
                }
                return response;
            }
        }
    }



