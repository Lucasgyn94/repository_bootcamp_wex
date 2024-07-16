using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

#pragma warning disable CS8600  // Desativar aviso CS8600
#pragma warning disable CS8604  // Desativar aviso CS8604
#pragma warning disable CS8602  // Desativar aviso CS8602
#pragma warning disable CS8600
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {

        private decimal preco_inicial;
        private decimal preco_por_hora;
        private List<string> veiculos;

        // criação do método construtor
        public Estacionamento(decimal preco_inicial, decimal preco_por_hora) {
            this.preco_inicial = preco_inicial;
            this.preco_por_hora = preco_por_hora;
            this.veiculos = new List<string>();
        }

        public bool VerificaPlacaValida (string placa) {
            string pattern = @"^[A-Z]{3}-\d{4}$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(placa)) {
                return true;
            } else {
                Console.WriteLine("Placa inválida. Digite uma placa no formato (AAA-1234)");
                return false;
            }
        }

        public void Adicionar_Veiculo() {
            Console.WriteLine("Digite a placa do veículo: ");
            string placa = Console.ReadLine();
            if (VerificaPlacaValida(placa)) {
                veiculos.Add(placa);
            }
        }

        public void Remover_Veiculos() {
            Console.WriteLine("Digite a placa do veículo para remover: ");

            string placa = "";
            placa = Console.ReadLine();

            if (veiculos.Any(elemento=>elemento.ToUpper() == placa.ToUpper())) {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int horas = 0;
                decimal valor_total = 0;

                horas = Convert.ToInt32(Console.ReadLine());
                valor_total = preco_inicial + (horas * preco_por_hora);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de R$ {valor_total}");
            } else {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");

            }

        }

        public void Atualizar_Veiculos(string placa, string nova_placa) {
            if (veiculos.Contains(placa)) {
                int posicao = veiculos.IndexOf(placa);
                veiculos[posicao] = nova_placa;
                Console.WriteLine($"Placa atualizada com sucesso! Nova placa: {nova_placa} .");
            } else {
                Console.WriteLine("Veículo não encontrado no estacionamento.");
            }

        }

        public void Listar_Veiculos() {
            if (veiculos.Any()) {
                Console.WriteLine("Os veículos estacionados são: ");

                veiculos.ForEach(veiculo => Console.WriteLine(veiculo));
            } else {
                Console.WriteLine("Não há veículos estacionados");
            }
        }
        
    }
}