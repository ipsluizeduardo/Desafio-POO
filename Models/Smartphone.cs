using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_POO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set;}
        private string _imei { get; set;}
        private string Modelo { get; set; }        
        private int Memoria { get; set;}

        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            _imei = imei;
            Modelo = modelo;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigação()
        {
            Console.WriteLine("Recebendo ligação");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}