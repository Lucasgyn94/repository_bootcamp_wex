using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_calculadora_operadores_aritmeticos.Models
{
    public class Calculadora
    {
        public void Somar (int num1, int num2) {
            Console.WriteLine($"Soma de{num1} + {num2} = {num1 + num2}");
        }
        public void Subtrair (int num1, int num2) {
            Console.WriteLine($"Subtração de {num1} - {num2} = {num1 - num2}");
        }
        
        public void Multiplicar (int num1, int num2) {
            Console.WriteLine($"Multiplicação de {num1} * {num2} = {num1 * num2}");
        }

        public void Dividir (int num1, int num2) {
            Console.WriteLine($"Divisão de {num1} / {num2} = {num1 / num2}");
        }

        // adicionando potência

        public void Potencia (int num1, int num2) {
            double potencia = Math.Pow(num1, num2);
            Console.WriteLine($"{num1} ^ {num2} = {potencia}");
        }

        // adicionando funções trigonométricas () seno, cosseno e tangente
        public void Seno (double angulo) {
            double radiano = angulo * (Math.PI / 180);
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }

        public void Cosseno (double angulo) {
            double radiano = angulo * (Math.PI / 180);
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno {angulo} = {Math.Round(cosseno, 4)}");
        }

        public void Tangente (double angulo) {
            double radiano = angulo * (Math.PI / 180);
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente)}");
        }

        public void RaizQuadrada (double numero) {
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"Raiz quadrada de {numero} = {raiz}");
        }
        public void IncrementarNumero (int numero) {
            int numero_incrementado = numero + 1;
            Console.WriteLine($"Incrementando {numero}. Novo valor = {numero_incrementado} ");
        }
        
        public void DecrementarNumero (int numero) {
            int numero_decrementado = numero - 1;
            Console.WriteLine($"Decrementando {numero}. Virou {numero_decrementado}");
        }
    }
}