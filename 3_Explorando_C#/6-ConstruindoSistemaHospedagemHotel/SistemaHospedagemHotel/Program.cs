using System;
using SistemaHospedagemHotel.Models;

public class Program {
    public static void Main(string[] args) {
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa("Lucas", "Ferreira");
        Pessoa p2 = new Pessoa("Tampinha", "Silva");

        hospedes.Add(p1);
        hospedes.Add(p2);

        // criando a suite
        Suite suite = new Suite("Premium", 2, 30);

        // cria reserva
        Reserva reserva = new Reserva(1);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        
        Console.WriteLine($"Hospédes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valór total diária: {reserva.CalcularValorDiaria()}");
        
    }
}