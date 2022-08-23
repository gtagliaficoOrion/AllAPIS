using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllAPIS.Entities
{
    public class RecibidoTasa
    {
        public _Antibloqueo _antibloqueo { get; set; }
        public _Labels _labels { get; set; }
        public _Timestamp _timestamp { get; set; }
        public USD USD { get; set; }
        public EUR EUR { get; set; }
        public COL COL { get; set; }
        public GOLD GOLD { get; set; }
        public USDVEF USDVEF { get; set; }
        public USDCOL USDCOL { get; set; }
        public EURUSD EURUSD { get; set; }
        public BCV BCV { get; set; }
        public MISC MISC { get; set; }
    }

        public class _Antibloqueo
        {
            public string mobile { get; set; }
            public string video { get; set; }
            public string corto_alternativo { get; set; }
            public string enable_iads { get; set; }
            public string enable_admobbanners { get; set; }
            public string enable_admobinterstitials { get; set; }
            public string alternativo { get; set; }
            public string alternativo2 { get; set; }
            public string notifications { get; set; }
            public string resource_id { get; set; }
        }

        public class _Labels
        {
            public string a { get; set; }
            public string a1 { get; set; }
            public string b { get; set; }
            public string c { get; set; }
            public string d { get; set; }
            public string e { get; set; }
        }

        public class _Timestamp
        {
            public string epoch { get; set; }
            public string fecha { get; set; }
            public string fecha_corta { get; set; }
            public string fecha_corta2 { get; set; }
            public string fecha_nice { get; set; }
            public string dia { get; set; }
            public string dia_corta { get; set; }
        }

        public class USD
        {
            public float transferencia { get; set; }
            public float transfer_cucuta { get; set; }
            public float efectivo { get; set; }
            public float efectivo_real { get; set; }
            public float efectivo_cucuta { get; set; }
            public float promedio { get; set; }
            public float promedio_real { get; set; }
            public float cencoex { get; set; }
            public float sicad1 { get; set; }
            public float sicad2 { get; set; }
            public float bitcoin_ref { get; set; }
            public float localbitcoin_ref { get; set; }
            public float dolartoday { get; set; }
        }

        public class EUR
        {
            public float transferencia { get; set; }
            public float transfer_cucuta { get; set; }
            public float efectivo { get; set; }
            public float efectivo_real { get; set; }
            public float efectivo_cucuta { get; set; }
            public float promedio { get; set; }
            public float promedio_real { get; set; }
            public float cencoex { get; set; }
            public float sicad1 { get; set; }
            public float sicad2 { get; set; }
            public float dolartoday { get; set; }
        }

        public class COL
        {
            public float efectivo { get; set; }
            public float transfer { get; set; }
            public float compra { get; set; }
            public float venta { get; set; }
        }

        public class GOLD
        {
            public int rate { get; set; }
        }

        public class USDVEF
        {
            public int rate { get; set; }
        }

        public class USDCOL
        {
            public float setfxsell { get; set; }
            public float setfxbuy { get; set; }
            public float rate { get; set; }
            public float ratecash { get; set; }
            public float ratetrm { get; set; }
            public float trmfactor { get; set; }
            public float trmfactorcash { get; set; }
        }

        public class EURUSD
        {
            public float rate { get; set; }
        }

        public class BCV
        {
            public string fecha { get; set; }
            public string fecha_nice { get; set; }
            public string liquidez { get; set; }
            public string reservas { get; set; }
        }

        public class MISC
        {
            public string petroleo { get; set; }
            public string reservas { get; set; }
        }
    }
