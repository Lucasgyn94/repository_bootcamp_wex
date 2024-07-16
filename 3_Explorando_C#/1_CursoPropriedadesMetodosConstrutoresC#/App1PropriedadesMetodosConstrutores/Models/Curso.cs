using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1PropriedadesMetodosConstrutores.Models
{
    public class Curso
    {
        public string Nome {get; set;}
        public List<Pessoa> Alunos {get; set;}

        // metodo adicionar aluno
        public void AdicionarAluno(Pessoa aluno) {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados() {
            int qtd_alunos = this.Alunos.Count;
            return qtd_alunos;
        }

        public void RemoverAluno(Pessoa aluno) {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos() {
            Console.WriteLine($"Alunos do curso de {this.Nome}");
            Alunos.ForEach(aluno => Console.WriteLine(aluno.NomeCompleto));
        }
    }
}