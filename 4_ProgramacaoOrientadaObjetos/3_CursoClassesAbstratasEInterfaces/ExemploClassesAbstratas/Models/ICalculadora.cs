using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClassesAbstratas.Models
{
    public interface ICalculadora
    {
        int Somar(int n1, int n2);
        int Subtrair(int n1, int n2);
        int Multiplicar(int n1, int n2);
        int Dividir(int n1, int n2);
    
        double Potencia(double n1, double n2) {
            return Math.Pow(n1, n2);
        }
    }
}