using System;
using ExemploPOO.Models;

public class Program {

    public static void InstanciaPessoa() {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Lucas";
        p1.Idade = 29;
        p1.Apresentar();
    }
    public static void Main(string[] args) {
        
        ContaCorrente c1 = new ContaCorrente(1234, 1000);
        c1.ExibirSaldo();
        c1.Sacar(1200);
        c1.ExibirSaldo();
    }
}