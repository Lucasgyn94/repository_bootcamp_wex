using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploHerancaAndPolimorfismo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario{get;set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou o professor {Nome}, tenho {Idade} anos e ganho {Salario}");
        }
    }
}