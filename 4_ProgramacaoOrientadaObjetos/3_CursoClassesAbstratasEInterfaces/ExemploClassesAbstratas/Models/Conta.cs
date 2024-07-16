using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClassesAbstratas.Models
{
    public abstract class Conta
    {
        // com protected as classes filhas podem alterar
        protected decimal _saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo() {
            Console.WriteLine($"Seu saldo é de {_saldo}");
        }
        
    }
}