using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.Models
{
    public class Calculadora
    {
        // criando uma variavel de lista para acessar em cada método
        private List<string> listaHistorico;
        private string data;
        public Calculadora(string data) {
            listaHistorico = new List<string>();
            this.data = data;
        }
        public int Somar(int n1, int n2) {
            int resultado = n1 + n2;
            // empurrando sempre os ultimos para o primeiro da lista
            listaHistorico.Insert(0, $"Res: {resultado} - data {data}");
            return resultado;
        }
        public int Subtrair(int n1, int n2) {
            int resultado = n1 - n2;
            // empurrando sempre os ultimos para o primeiro da lista
            listaHistorico.Insert(0, $"Res: {resultado} - data {data}");
            return resultado;
        }
        public int Multiplicar(int n1, int n2) {
            int resultado = n1 * n2;
            // empurrando sempre os ultimos para o primeiro da lista
            listaHistorico.Insert(0, $"Res: {resultado} - data {data}");
            return resultado;
        }
        public int Dividir(int n1, int n2) {
            int resultado = n1 / n2;
            // empurrando sempre os ultimos para o primeiro da lista
            listaHistorico.Insert(0, $"Res: {resultado} - data {data}");
            return resultado;
        }

        public List<string> historico () {
            // retornando os 3 ultimos do historio
            List<string> resultado;
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}