using System;
using System.Globalization;
using Newtonsoft.Json;
using NugetSerializarAndAtributos.Models;

public class Program {

    public static void SerializaObjeto() {
        // pegando a data de hj
        DateTime dataAtual = DateTime.Now;
        
        // criando uma lista para agrupar as nossas vendas
        List<Venda> listaVendas = new List<Venda>();

        Venda v1 = new Venda(1, "Matérial Escritório", 25.00M, dataAtual);
        Venda v2 = new Venda(2, "Licença Windows", 120.00M, dataAtual);
        
        // adicionando vendas a lista de vendas
        listaVendas.Add(v1);
        listaVendas.Add(v2);
        // serializando (transformando objeto em formato json)
        string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

        // compartilhando o objeto serializado e mandando escrever em Arquivos/vendas.json
        File.WriteAllText("Arquivos/vendas.json", serializado);
        Console.WriteLine(serializado);
    }

    public static void DeserealizaParaObjeto() {
    // leitura dos arquivos
        string conteudo_arquivo = File.ReadAllText("Arquivos/vendas.json");

        // deserialize do objeto
        List<Venda> listaDeVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudo_arquivo);
        // percorrento a lista

        foreach (Venda venda in listaDeVendas) {
            Console.WriteLine(
                $"Id: {venda.Id}\n" +
                $"Produto: {venda.Produto}\n" +
                $"Preco: {venda.Preco}\n" +
                $"DataVenda: {venda.DataVenda.ToString("dd-MM-yyyy HH:mm")}\n"  
            );
        } 
    }
    public static void Main(string[] args) {
        DeserealizaParaObjeto();

    }
}