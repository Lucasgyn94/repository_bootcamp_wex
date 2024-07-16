int quantidadeProdutosEstoque = 10;

Console.WriteLine("### Vendas de Produtos ###");
Console.WriteLine($"Quantidade de produtos em estoque: {quantidadeProdutosEstoque}");
Console.WriteLine("Digite a quantidade de produtos para compra: ");
int quantidadeProdutosVendidos = Convert.ToInt32(Console.ReadLine());

bool possivelVenda = quantidadeProdutosEstoque >= quantidadeProdutosVendidos;

quantidadeProdutosEstoque = quantidadeProdutosEstoque - quantidadeProdutosVendidos;

Console.WriteLine($"Quantidade de produtos comprados: {quantidadeProdutosVendidos}");

if (possivelVenda) {
    Console.WriteLine("Venda realizada com sucesso!");
} else {
    Console.WriteLine("Não temos mais produtos em estoque");
}

if (possivelVenda) {
    Console.WriteLine($"Produtos em estoque disponível? {possivelVenda}");
    Console.WriteLine($"Ainda existem {quantidadeProdutosEstoque} produtos em estoque!");
} else {
    Console.WriteLine($"Produtos em estoque disponível? {possivelVenda}");
Console.WriteLine($"Não existem mais produtos em estoque!");

}


