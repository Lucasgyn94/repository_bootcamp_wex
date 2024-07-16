using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    public class Reserva
    {
        public Reserva() {
        }

        public Reserva(int diasReservados) {
            this.DiasReservados = diasReservados;
            this.Suite = new Suite();
            this.ListaHospede = new List<Pessoa>();
        }
        List<Pessoa> ListaHospede {get; set;}
        Suite Suite {get; set;}
        int DiasReservados {get; set;}

        // cadastrando hospede
        public void CadastrarHospedes(List<Pessoa> hospedes) {
            // verificando se a capacidade da suite e menor ou igual ao numero de hospedes sendo recebido
            if (ListaHospede.Count + hospedes.Count <= this.Suite.Capacidade) {
                this.ListaHospede = hospedes;
            } else {
                throw new ArgumentException("Capacidade menor do que número de hospedes!");
            }
        }

        public void CadastrarSuite(Suite suite) {
            this.Suite = suite;
        }

        // retornando a quantidade de hospedes
        public int ObterQuantidadeHospedes() {
            int qtdHospedes = ListaHospede.Count;
            return qtdHospedes;
        }
        // retornando valor diária
        public decimal CalcularValorDiaria() {
            decimal valor = 0;

            decimal ValorDiaria = this.DiasReservados * this.Suite.ValorDiaria;
            
            if (DiasReservados >= 10) {
                decimal desconto = ValorDiaria * 0.10M;
                valor = ValorDiaria - desconto;

            } else {
                valor = ValorDiaria;
            }

            return valor;
        }
    }
}