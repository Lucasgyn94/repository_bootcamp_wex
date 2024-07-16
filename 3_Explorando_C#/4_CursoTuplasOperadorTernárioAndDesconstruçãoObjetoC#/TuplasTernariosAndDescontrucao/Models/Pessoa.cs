using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuplasTernariosAndDescontrucao.Models
{
    public class Pessoa
    {
        public Pessoa() {
            // metodo construtor vazio
        }

        public Pessoa(string nome, string sobrenome) {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
        // metodo deconstrutor
        public void Deconstruct(out string nome, out string sobrenome) {
            nome = this.Nome;
            sobrenome = this.Sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome
        {
            get => this._nome.ToUpper();

            set{
                if (value == "") {
                    throw new ArgumentException("O nome não pode ser vazio");
                } 
                    this._nome = value;
            }
        }

        public string Sobrenome {get; set;}

        public string NomeCompleto {get => $"{this.Nome} {this.Sobrenome}";}
        public int Idade
        {
            get => this._idade;

            set
            {
                if (value < 0) {
                    throw new ArgumentException("Idade não pode ser negativa!");
                }

                this._idade = value;
            }
        }

        public void Apresentar() {
            Console.WriteLine($"Olá me chamo {this.NomeCompleto} e tenho {this.Idade} anos de idade");
        }
    }
}