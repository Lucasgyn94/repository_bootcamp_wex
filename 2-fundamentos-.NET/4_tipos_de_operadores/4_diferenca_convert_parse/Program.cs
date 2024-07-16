// diferença e no tratamento de valores nulos
int a = Convert.ToInt32(null);
// com parse caso haja um valor nulo, o programa e encerrado, com convert não.
int b = int.Parse(null);

Console.WriteLine(a);
Console.WriteLine(b);