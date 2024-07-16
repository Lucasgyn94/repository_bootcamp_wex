using System;
using App1PropriedadesMetodosConstrutores.Models;

public class Program {

    public void ApresentacaoPessoa() {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Lucas";
        pessoa.Sobrenome = "Ferreira";
        pessoa.Idade = 29;
        pessoa.Apresentar();
    }
    public static void Main(string[] args) {
        
        Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Ferreira");

        Pessoa p2 = new Pessoa();
        p2.Nome = "Tampinha";
        p2.Sobrenome = "Silva";

        Curso curso_de_ingles = new Curso();
        curso_de_ingles.Nome = "Inglês";
        curso_de_ingles.Alunos = new List<Pessoa>();

        curso_de_ingles.AdicionarAluno(p1);
        curso_de_ingles.AdicionarAluno(p2);
        curso_de_ingles.ListarAlunos();
        
    }
}