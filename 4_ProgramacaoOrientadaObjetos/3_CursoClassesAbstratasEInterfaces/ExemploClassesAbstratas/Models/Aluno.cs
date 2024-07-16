using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClassesAbstratas.Models
{
    public class Aluno : Pessoa
    {   
        // herdando construtor da classe Pessoa. No base(nome) eu estou chamando o construtor pai, passando o nome.
        public Aluno(string nome) : base(nome) {
        }
        public double Nota{get; set;}
        public override void Apresentar() {
            Console.WriteLine($"Olá, me chamo {Nome} tenho {Idade} anos e sou aluno nota: {Nota}");
        }
    }
}