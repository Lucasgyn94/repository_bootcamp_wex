int mes = 0;

Console.WriteLine("### Verificação de Vogal e Consoante");
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();
if (letra.Length == 1) {
    switch (letra) {
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
            Console.WriteLine("Vogal");
            break;
        default:
            Console.WriteLine("Consoante");
            break;

    }
} else {
    Console.WriteLine("Deve ser digitado apenas um caracter (letra).");
}
