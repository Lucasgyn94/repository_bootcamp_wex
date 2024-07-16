using System.Collections.Concurrent;

string nome = "Lucas";
int idade = 29;
decimal dinheiroEmConta = 10.90m; 
double altura = 1.80;
bool condicao = true;

Console.WriteLine( $"Nome: {nome}" +
                    $"\nIdade: {idade}" +
                    $"\nDinheiro em conta: {dinheiroEmConta}" +
                    $"\nAltura: {altura.ToString("0.00")}" +
                    $"\nCondição: {condicao}");
