using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_POO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo {nomeApp} esta sendo instalado...");
        }
    }
}