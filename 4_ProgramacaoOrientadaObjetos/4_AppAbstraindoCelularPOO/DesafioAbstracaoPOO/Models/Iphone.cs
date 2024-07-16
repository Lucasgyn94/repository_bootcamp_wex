using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioAbstracaoPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} em seu Iphone.");
        }

        public override string ToString()
        {
            string txt = "";
            txt +=      "\n=== Iphone XS ===\n" +
                        "Número: " + Numero + "\n" +
                        "Modelo: " + _modelo + "\n" +
                        "IMEI: " + _imei + "\n" +
                        "Memória: " + _memoria + "\n" +
                        "=============================";
            return txt;
        }


    }
}