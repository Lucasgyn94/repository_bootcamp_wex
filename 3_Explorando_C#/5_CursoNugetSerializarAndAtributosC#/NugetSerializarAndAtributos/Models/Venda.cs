using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NugetSerializarAndAtributos.Models
{
    public class Venda
    {
        public Venda () {

        }
        public Venda (int id, string produto, decimal preco, DateTime dataVenda) {
            this.Id = id;
            this.Produto = produto;
            this.Preco = preco;
            this.DataVenda = dataVenda;
        }

        public int Id {get; set;}
        
        // passando o nome do atributo q ta vindo do json
        [JsonProperty("Nome_Produto")]
        public string Produto {get; set;}
        public decimal Preco {get; set;}

        public DateTime DataVenda {get; set;}
    }
}