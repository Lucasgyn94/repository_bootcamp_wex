using System;
using ExcessoesAndColecoes.Models;

public class Program {

    public static void RealizaLeituraArquivos() {
        string[] linhas = File.ReadAllLines("Arquivos/texto_Arquivo.txt");

        foreach (string linha in linhas) {
        Console.WriteLine(linha);
        }
    }

    public static void TratandoExcessaoGenerica() {
        try {
            string[] linhas = File.ReadAllLines("Arquivos/texto_Arquivo.txt");

            foreach (string linha in linhas) {
            Console.WriteLine(linha);
        }
        } catch (Exception ex) {
            Console.Write($"Ocorreu uma excessão genérica! {ex.Message}");
        }
    }

    public static void TratandoExcessaoEspecifica() {
        try {
            string[] linhas = File.ReadAllLines("Arquivos/textoArquivo.txt");

            foreach (string linha in linhas) {
            Console.WriteLine(linha);
            }
        } 
        catch (DirectoryNotFoundException ex) {
            Console.Write($"Ocorreu um erro na leitura do arquivo! Caminho da pasta não encontrado! {ex.Message}");
        }
        catch (FileNotFoundException ex) {
            Console.Write($"Ocorreu um erro na leitura do arquivo! Arquivo não encontrado! {ex.Message}");
        }
        catch (Exception ex) {
            Console.Write($"Ocorreu uma excessão genérica! {ex.Message}");
        } finally {
            Console.WriteLine("\nFinalmente aqui");
        }
    }

    public static void UsandoThrow() {
        ExemploExcecao ex1 = new ExemploExcecao();
        ex1.Metodo1();
    }

    public static void ManipulaFilas() {
        // criando uma fila (fifo = primeiro entrar, primeiro a sair)
       Queue<int> fila = new Queue<int>();
       fila.Enqueue(2);
       fila.Enqueue(4);
       fila.Enqueue(6);
       fila.Enqueue(8);

       foreach(int elemento in fila) {
        Console.WriteLine(elemento);
       }

       // removendo um elemento da fila (no caso e removido sempre o primeiro)
       Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
       
       foreach(int elemento in fila) {
        Console.WriteLine(elemento);
       }

    }

    public static void ManipulaPilhas() {
        Stack<int> pilha = new Stack<int>();
        pilha.Push(2);
        pilha.Push(4);
        pilha.Push(6);
        pilha.Push(8);

        foreach(int item in pilha) {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine($"Removendo o elemento {pilha.Pop()}");

        pilha.Push(20);
               
        foreach(int item in pilha) {
            Console.WriteLine($"{item}");
        }

    }

    public static void ManipulaDicionarios() {
        Dictionary<string, string> estados = new Dictionary<string, string>();
        estados.Add("GO", "Goiás");
        estados.Add("SP", "São Paulo");
        estados.Add("MG", "Minas Gerais");
        estados.Add("RS", "Rio Grande Do Sul");

        foreach(KeyValuePair<string, string> item in estados) {
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }

        // removendo são paulo(para removermos basta passar a chave)
        Console.WriteLine($"\nRemovendo\n--------------------------------\n");
         foreach(KeyValuePair<string, string> item in estados) {
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }

        Console.WriteLine("\nAtualizando chave\n");
        estados["SP"] = "São Paulo - Alterado";

        foreach(KeyValuePair<string, string> item in estados) {
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }
        
        string chave = "GO";
        Console.WriteLine($"Verificando o elemento {chave}");

        if (estados.ContainsKey(chave)) {
            Console.WriteLine($"A chave {chave} já está na lista.");
        } else {
            Console.WriteLine($"A chave {chave} não está na lista. É seguro adicionar.");
        }

    }
    public static void Main(string[] args) {
        
    }

}
