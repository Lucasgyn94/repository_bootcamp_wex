using System;
using NewTalents.Models;

public class Program {
    public static void Main(string[] args) {
        Calculadora calculadora = new Calculadora("05/11/2023");
        calculadora.Somar(5,4);
        calculadora.Somar(10,4);
        calculadora.Somar(10,10);
        calculadora.Dividir(20,2);
        calculadora.Dividir(10,2);

        foreach (var operacao in calculadora.historico()) {
            Console.WriteLine(operacao);
        }
    }
}