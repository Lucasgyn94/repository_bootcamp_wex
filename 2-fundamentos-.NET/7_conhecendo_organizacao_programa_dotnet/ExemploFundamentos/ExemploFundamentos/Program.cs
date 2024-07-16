using ExemploFundamentos.Common.Models;

public class Program {
    public static void Main(string[] args) {
        Pessoa p = new Pessoa();
        p.Nome = "Lucas";
        p.Idade = 29;
        p.Apresentar();
    }
}