using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    public class Pessoa
    {
        public Pessoa (String nome) {
            Nome = nome;
        }

        public Pessoa (string nome, string sobrenome) {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            
        }
        

        public string Nome 
        {
            get;
            set;
        }
        public string Sobrenome 
        {
            get; set;
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}