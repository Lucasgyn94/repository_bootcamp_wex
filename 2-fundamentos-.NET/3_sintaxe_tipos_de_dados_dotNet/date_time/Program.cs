DateTime dataAtual = DateTime.Now;
Console.WriteLine($"Data atual: {dataAtual}");

// hoje mais 5 dias
DateTime hojeMais5dias = DateTime.Now.AddDays(5);
Console.WriteLine($"Hoje mais 5 dias: {hojeMais5dias}");

// formatando a data
DateTime dataFormatada = DateTime.Now;
Console.WriteLine($"Data formatada: {dataFormatada.ToString("dd/MM/yyyy")}");

