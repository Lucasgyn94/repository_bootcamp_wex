using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    public class Suite
    {
        public Suite() {
            // construtor vazio
        }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria) {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        public string TipoSuite{get; set;}
        public int Capacidade{get;set;}
        public decimal ValorDiaria{get; set;}
    }
}