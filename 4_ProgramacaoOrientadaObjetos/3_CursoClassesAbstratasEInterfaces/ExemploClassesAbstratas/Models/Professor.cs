using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClassesAbstratas.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome) {
        }

        public decimal Salario{get;set;}
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome}, tenho {Idade} anos, sou professor e ganho R$ {Salario}");
        }

        // declarando o metodo como selado para n ser possivel sobreescrevelo
        /*
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome}, tenho {Idade} anos, sou professor e ganho R$ {Salario}");
        }
        */      
    }
}


/*CASO EU NÃO QUEIRA QUE NENHUMA OUTRA CLASSE HERDE DE PROFESSOR, BASTA COLOCAR SEALED APOS A PALAVRA PUBLIC*/

/*

 public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome) {
        }

        public decimal Salario{get;set;}

        // declarando o metodo como selado para n ser possivel sobreescrevelo
        
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome}, tenho {Idade} anos, sou professor e ganho R$ {Salario}");
        }
        

        // apresentar sem estar selado podendo ser sobreescrito
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome}, tenho {Idade} anos, sou professor e ganho R$ {Salario}");
        }
    }
*/