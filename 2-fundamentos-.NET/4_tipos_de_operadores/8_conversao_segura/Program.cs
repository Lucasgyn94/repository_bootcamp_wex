string a = "15-";

// tryparse e a melhor maneira de tratar uma conversão
int b = 0;
string texto = "o valor não é um número!";
int.TryParse(a, out b);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!");