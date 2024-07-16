using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1ManipulacaoValoresC_.Models
{
    public class Curso
    {
        public string Nome {get; set;}
        public List<Pessoa> Alunos {get; set;} 

        public void AdicionarAluno(Pessoa Aluno) {
            Alunos.Add(Aluno);
        }

        public void ObterQuantidadeDeAlunos() {
            int qtd_alunos = Alunos.Count;
            Console.WriteLine($"Quantidade de alunos: {qtd_alunos}");
        }
        public void RemoverAluno(Pessoa Aluno) {
            Alunos.Remove(Aluno);
        }

        public void ListarAlunos() {
            Console.WriteLine($"Alunos do curso de {this.Nome}");
            for (int i = 0; i < Alunos.Count; i++) {
                Console.WriteLine($"{i + 1}ª Aluno: {Alunos[i].NomeCompleto}");
            }
        }
    }
}