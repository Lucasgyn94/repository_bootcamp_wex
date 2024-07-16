using System;
using TuplasTernariosAndDescontrucao.Models;

public class Program {

    public static void ManipulaTuplaFormaPrincipal() {
        (int, string, string, int) minhaTupla = (1, "Lucas", "Ferreira", 29);
        
        Console.WriteLine($"Id: {minhaTupla.Item1}");
        Console.WriteLine($"Nome: {minhaTupla.Item2}");
        Console.WriteLine($"Sobrenome: {minhaTupla.Item3}");
        Console.WriteLine($"Idade: {minhaTupla.Item4}");

    }

    public static void ManipulaTuplaFormaDois() {
        ValueTuple<int, string, string, int> minhaTupla = (1, "Lucas", "Ferreira", 29);
        Console.WriteLine($"Id: {minhaTupla.Item1}");
        Console.WriteLine($"Nome: {minhaTupla.Item2}");
        Console.WriteLine($"Sobrenome: {minhaTupla.Item3}");
        Console.WriteLine($"Idade: {minhaTupla.Item4}");
    }

    public static void ManipulaTuplaFormaTres() {
        var tuplaCreate = Tuple.Create(1, "Lucas", "Ferreira", 29);
        Console.WriteLine($"Id: {tuplaCreate.Item1}");
        Console.WriteLine($"Nome: {tuplaCreate.Item2}");
        Console.WriteLine($"Sobrenome: {tuplaCreate.Item3}");
        Console.WriteLine($"Idade: {tuplaCreate.Item4}");
    }

    public static void LeituraLinhasArquivo() {
        LeituraArquivo arquivo = new LeituraArquivo();
        var (sucesso, linhasArquivo, qtdLinhas) = arquivo.LerArquivo("Arquivo/ArquivoLeitura.txt");

        if (sucesso) { 
            Console.WriteLine("Quantidade de linhas do arquivo: " + qtdLinhas);
            foreach(string linha in linhasArquivo) {
                Console.WriteLine(linha);
            } 
        } else {
                Console.WriteLine("Não foi possível ler o arquivo");
        }
    }

    public static void Descartes() {
        LeituraArquivo arquivo = new LeituraArquivo();
        var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivo/ArquivoLeitura.txt");

        if (sucesso) { 
            Console.WriteLine("Quantidade de linhas do arquivo Descartada! ");
            foreach(string linha in linhasArquivo) {
                Console.WriteLine(linha);
            } 
        } else {
                Console.WriteLine("Não foi possível ler o arquivo");
        }
    }

    public static void ChamaDeconstrutor() {
        Pessoa p1 = new Pessoa("Lucas", "Ferreira");
        (string nome, string sobrenome) = p1;
        Console.WriteLine(nome + ' ' +  sobrenome);
    }

    public static void VerificaSeParOuImpar() {
        Console.WriteLine($"Digite um número para verificar se par ou ímpar: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        bool ehPar = false;

        ehPar = (numero % 2 == 0);

        Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

    }
    public static void Main(string[] args) {
        
        
    }
}