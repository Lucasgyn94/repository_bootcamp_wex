using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;

public class Program {
    
    public static void TabuadaEstruturaFor() {
        
        Console.WriteLine("### Tabuada de Multiplicação ###");
        Console.Write("Digite um número para ver a sua tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= 10; i++) {
            Console.WriteLine($"{numero} * {i} = {numero * i}");
        }
    }

    public static void TabuadaEstruturaWhile() {
        Console.WriteLine("### Tabuada de Multiplicação ###");
        Console.Write("Digite um número para ver a sua tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int contador = 0;

        while (contador <= 10) {
            Console.WriteLine($"{contador + 1}º Execução: {numero} * {contador} = {numero * contador}");
            contador++;
        }
    }

     public static void TabuadaEstruturaWhileComInterrupcao() {

        Console.WriteLine("### Tabuada de Multiplicação ###");
        Console.Write("Digite um número para ver a sua tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int contador = 0;

        while (contador <= 10) {
            Console.WriteLine($"{contador + 1}º Execução: {numero} * {contador} = {numero * contador}");
            contador++;

            if (contador == 6) {
                break;
            }
        }
    }

    public static void SomarNumeros() {
        int numero = 0;
        int soma = 0;

        Console.WriteLine("### Somátoria de Números ###");
        Console.WriteLine("Digite um número e 0 para sair.");

        do {
            numero = Convert.ToInt32(Console.ReadLine());
            soma = soma + numero;   
        } while (numero != 0);

        Console.WriteLine($"Soma dos números digitados = {soma}" );

    }

    public static void Main(String[] args) {
        
        int opcao = 0;
        Boolean menu_de_opcoes = true;

        while (menu_de_opcoes) {
            
            //Console.Clear();
            Console.WriteLine("### Menu de Opções ###");
            Console.WriteLine("Digite sua opção: ");
            Console.WriteLine("1- Cadastrar usuário");
            Console.WriteLine("2- Buscar usuário");
            Console.WriteLine("3- Deletar usuário");
            Console.WriteLine("4- Encerrar programa");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch(opcao) {
                case 1:
                    Console.WriteLine("Cadastro de usuário\n");
                    break;
                case 2:
                    Console.WriteLine("Buscar usuário\n");
                    break;
                case 3:
                    Console.WriteLine("Deletar usuário\n");
                    break;
                case 4:
                    menu_de_opcoes = false;
                    //Environment.Exit(0);
                    Console.WriteLine("Encerrando!\n");
                    break;
                default:
                    Console.WriteLine("Selecione uma entre as opções\n");
                    break;

            }
        }

        Console.WriteLine("Programa encerrado com sucesso!");

        

    }
        
}