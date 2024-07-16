using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldo) {
            NumeroConta = numeroConta;
            _saldo = saldo;
        }
        // encapsulamento do saldo
        private decimal _saldo;

        public int NumeroConta{get; set;}

        public void Sacar(decimal valor) {
            if (_saldo >= valor) {
                _saldo = _saldo - valor;
                Console.WriteLine("Saque realizado com sucesso!");
            } else {
                Console.WriteLine("Saque não realizado. Valor informado maior do que o seu saldo!");
            }
        }

        public void ExibirSaldo() {
            Console.WriteLine($"Seu saldo é de {_saldo}");
        }
        
    }
}