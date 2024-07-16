using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducao_classes.Pessoa
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        // public string nome {get; set;} dessa forma já fazemos o get e set automaticamente ao criar o atributo
        // public int idade {get; set;}
        
        public Pessoa() {
            // construtor vazio
        }
        public Pessoa(string nome, int idade) {
            this.nome = nome;
            this.idade = idade;
        }
       
        public string getNome() {
            return this.nome;
        }
        public int getIdade() {
            return this.idade;
        }

        public void setNome(string nome) {
            this.nome = nome;
        }
        public void setIdade(int idade) {
            this.idade = idade;
        }



        public void Apresentar() {
            Console.WriteLine($"Olá eu sou o {this.nome}" + 
            $"e tenho {this.idade} anos de idade");
        }
    }
}