using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1ManipulacaoValoresC_.Models
{
    public class Pessoa
    {
        // metodo construtor
        public Pessoa(string nome, string sobrenome) {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public Pessoa() {
            // Construtor vazio
        }
        private string _nome;
        private int _idade;

        public string Nome 
        {
            get => this._nome;

            set
            {
                if (value == "") {
                    throw new ArgumentException("O nome não pode ser vazio!");
                } else {
                    this._nome = value;
                }
            }
        }
        public string Sobrenome {get;set;}
        public string NomeCompleto {get => $"{this.Nome} {this.Sobrenome}";}
        public int Idade 
        {
            get => this._idade;

            set
            {
                if (value < 0 || value > 120) {
                    throw new ArgumentException("Informe uma idade entre 0 e 120 anos!");
                } else {
                    this._idade = value;
                }
            }    
        }
        
        public void Apresentar() {
            Console.WriteLine($"Olá, me chamo {NomeCompleto} e tenho {Idade} anos");
        }


    }
}