using System;
using ExemploClassesAbstratas.Models;

public class Program {

    public static void ConstrutorPorHeranca() {
        Aluno a1 = new Aluno("Lucas");
        a1.Idade = 29;
        a1.Nota = 10;
        a1.Apresentar();
    }

    public static void SobrescritaObject() {
        Computador c = new Computador();
        Console.WriteLine(c.ToString());
    }
    public static void Main(string[] args) {
        CalculadoraComum cc = new CalculadoraComum();
        /*
        Console.WriteLine(cc.Dividir(10, 2));
        Console.WriteLine(cc.Multiplicar(10, 2));
        Console.WriteLine(cc.Somar(10, 2));
        Console.WriteLine(cc.Subtrair(10, 2));
        */
        Console.WriteLine(cc);

    }
}