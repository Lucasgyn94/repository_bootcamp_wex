using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioAbstracaoPOO.Models
{
    public abstract class Smartphone
    {
        // propriedade publica
        public string Numero{get; set;}
        // campos protegidos
        protected string _modelo;
        protected string _imei;
        protected int _memoria;

        // metodo construtor
        public Smartphone(string numero, string modelo, string imei, int memoria) {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar() {
            Console.WriteLine("\nEfetuando ligação...");
        }

        public void ReceberLigacao() {
            Console.WriteLine("\nRecebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nome);
        
    }
}