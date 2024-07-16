using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClassesAbstratas.Models
{
    public class CalculadoraComum : ICalculadora
    {
        public int Dividir(int n1, int n2)
        {   
            int resultado = 0;

            if (n2 == 0) {
                Console.WriteLine("Não é possível divisão por 0!");
            } else {
                resultado = n1 / n2;
            }
            return resultado;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
 
    }
}