using System;
using ExemploHerancaAndPolimorfismo.Models;

public class Program {
    public static void Main(string[] args) {
        Aluno a1 = new Aluno();
        a1.Nome = "Lucas";
        a1.Idade = 29;
        a1.Nota = 10;
        a1.Apresentar();

        Professor p1 = new Professor();
        p1.Nome = "Lucas";
        p1.Idade = 29;
        p1.Salario = 5000M;
        p1.Apresentar();
    }
}