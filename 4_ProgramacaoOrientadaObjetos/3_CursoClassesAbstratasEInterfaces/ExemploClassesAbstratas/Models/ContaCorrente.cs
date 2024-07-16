using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace ExemploClassesAbstratas.Models
{
    public class ContaCorrente : Conta
    {
        // construtor por heranca
        public ContaCorrente(decimal saldo) {
            _saldo = saldo;
        }

        public override void Creditar(decimal valor)
        {
            _saldo = _saldo + valor;
        }

    }
}