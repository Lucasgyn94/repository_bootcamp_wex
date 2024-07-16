using System;
using DesafioFundamentos.Models;

#pragma warning disable CS8600
#pragma warning disable CS8604

public class Program {
    public static void Main(string[] args) {
        // definindo acentuação utf-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        decimal preco_inicial = 0;
        decimal preco_por_hora = 0;

        Console.WriteLine(  "$$$ Seja bem vindo ao sistema de estacionamento! $$$\n" + 
                            "Digite o preço inicial");
        preco_inicial = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Agora digite o preço por hora");
        preco_por_hora = Convert.ToDecimal(Console.ReadLine());

        // instancia a classe Estacionamento passando os valores para o construtor
        Estacionamento estacionamento = new Estacionamento(preco_inicial, preco_por_hora);

        int opcao = 0;
        
        do {
            Console.WriteLine("Digite a sua opção");
            Console.WriteLine("1- Cadastrar Veículo");
            Console.WriteLine("2- Remover Veículo");
            Console.WriteLine("3- Listar Veículo");
            Console.WriteLine("4- Atualizar Placa");
            Console.WriteLine("5- Encerrar Programa\n");

            
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao) {
                case 1:
                    estacionamento.Adicionar_Veiculo();
                    break;
                case 2:
                    estacionamento.Remover_Veiculos();
                    break;
                case 3:
                    estacionamento.Listar_Veiculos();
                    break;
                case 4:
                    Console.WriteLine("Digite a placa do veículo para atualizar: ");
                    string placa = Console.ReadLine();

                    Console.WriteLine("Digite a nova placa do veículo: ");
                    string nova_placa = Console.ReadLine();

                    estacionamento.Atualizar_Veiculos(placa, nova_placa);
                    break;
                case 5:
                        Console.WriteLine("\nObrigado por usar o meu sistema. Até breve!");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        } while (opcao != 5);

        Console.WriteLine("Programa encerrado com sucesso!");
        
    }
}