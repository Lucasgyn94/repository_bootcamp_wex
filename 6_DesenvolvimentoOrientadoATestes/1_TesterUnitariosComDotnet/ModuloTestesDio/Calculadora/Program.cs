using System;
using Calculadora.Services;

public class Program {
    public static void Main(string[] args) {
        CalculadoraImplementacao c = new CalculadoraImplementacao();

        int n1 = 5;
        int n2 = 10;

        Console.WriteLine($"{n1} + {n2} = {c.Somar(n1, n2)}");
    }
}