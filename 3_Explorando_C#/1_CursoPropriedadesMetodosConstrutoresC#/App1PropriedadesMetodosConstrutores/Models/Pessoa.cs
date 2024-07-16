using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace App1PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {

        // construtor padrão
        public Pessoa(string nome, string sobrenome) {
            this.Nome = nome;
            this.Sobrenome = sobrenome;

        }
        public Pessoa() {
            // construtor vazio
        }
        // campos
        private string _nome;
        private int _idade;

        // propriedades
        public string Nome 
        {
            get => this._nome; 
            
            set
            {
                if (value == "") {
                    throw new ArgumentException("O campo nome não pode ser vazio!");
                } else {
                    this._nome = value;
                }
            }
        }

        public string Sobrenome {get; set;}

        public string NomeCompleto {get => $"{this.Nome} {this.Sobrenome}";}
        public int Idade 
        {
            get => this._idade;
            
            set {
                if (value < 0 || value > 100) {
                    throw new ArgumentException("Informe uma idade válida entre 0 e 100.");
                } else {
                    this._idade = value;
                }
            }
        }

        public void Apresentar() {
            Console.WriteLine($"Nome: {this.NomeCompleto} - Idade: {this.Idade}");
        }
        
    }
}