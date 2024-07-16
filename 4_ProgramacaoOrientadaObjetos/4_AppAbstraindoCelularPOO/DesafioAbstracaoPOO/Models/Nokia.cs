using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioAbstracaoPOO.Models
{
    public class Nokia : Smartphone
    {
        
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} em seu Nokia.");
        }

        public override string ToString()
        {
            string txt = "";
            txt +=      "\n=== Smartphone Nokia ===\n" +
                        "Número: " + Numero + "\n" +
                        "Modelo: " + _modelo + "\n" +
                        "IMEI: " + _imei + "\n" +
                        "Memória: " + _memoria + "\n" +
                        "=============================";
            return txt;
        }
    }
}