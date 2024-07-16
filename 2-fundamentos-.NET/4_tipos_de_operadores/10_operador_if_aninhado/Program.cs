int quantidadeProdutosEstoque = 10;

Console.WriteLine("### Vendas de Produtos ###");
Console.WriteLine($"Quantidade de produtos em estoque: {quantidadeProdutosEstoque}");
Console.WriteLine("Digite a quantidade de produtos para compra: ");
int quantidadeProdutosComprados = Convert.ToInt32(Console.ReadLine());

bool possivelVenda = quantidadeProdutosComprados > 0 && quantidadeProdutosEstoque >= quantidadeProdutosComprados;

quantidadeProdutosEstoque = quantidadeProdutosEstoque - quantidadeProdutosComprados;

Console.WriteLine($"Quantidade de produtos comprados: {quantidadeProdutosComprados}");

if (quantidadeProdutosComprados == 0) {
    Console.WriteLine("Venda inválida!");
} 
else if (possivelVenda) {
    Console.WriteLine("Venda realizada com sucesso!");
    Console.WriteLine($"Produtos em estoque disponível? {possivelVenda}");
    Console.WriteLine($"Ainda existem {quantidadeProdutosEstoque} produtos em estoque!");
} else {
    Console.WriteLine($"Produtos em estoque disponível? {possivelVenda}");
    Console.WriteLine($"Desculpe! Não temos a quantidade de produtos desejada em estoque.");

}


