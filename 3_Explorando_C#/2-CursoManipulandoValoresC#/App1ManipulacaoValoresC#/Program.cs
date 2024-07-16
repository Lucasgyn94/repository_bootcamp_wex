using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using App1ManipulacaoValoresC_.Models;
public class program {

    public static void ManipulaAlunosCursoIngles() {
        Pessoa p1 = new Pessoa("Lucas", "Ferreira");
        
        Pessoa p2 = new Pessoa("Tampinha", "Silva");
        
        Curso c1 = new Curso();
        c1.Nome = "Inglês";
        c1.Alunos = new List<Pessoa>();

        c1.AdicionarAluno(p1);
        c1.AdicionarAluno(p2);
        c1.ListarAlunos();
        c1.ObterQuantidadeDeAlunos();

    }

    public static void JuncaoString() {
        string n1 = "10";
        string n2 = "20";
        string resultado = n1 + n2;
        Console.WriteLine(resultado); // 1020
    }

    public static void FormataValoresMonetarios() {
        decimal valor_monetario = 10000.40M;
        Console.WriteLine($"{valor_monetario:C} ");
    }

    public static void AlteraLocalizacaoCodigo() {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal valor_monetario = 10000.40M;
        Console.WriteLine($"{valor_monetario:C} ");

    }

    public static void AlteraLocalizacaoCultura() {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
        decimal valor_monetario = 10000.40M;
        Console.WriteLine($"{valor_monetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
    }

    public static void FormatacaoPersonalizada() {
        decimal valor_monetario = 10000.40M;
        Console.WriteLine($"{valor_monetario.ToString("C3")}"); // C = currency = moeda - 3 - numeros casas decimais
    }

    public static void RepresentaPorcentagem() {
        double porcentagem = .1234;
        Console.WriteLine(porcentagem.ToString("P"));
    }
    public static void FormataPorcentagem() {
        int numero = 123456;
        Console.WriteLine($"{numero.ToString("##-##-##")}");
       
    }

    public static void FormataDateTime() {
        DateTime data = DateTime.Now;
        Console.WriteLine(data.ToString("dd-MM-yyyy HH:mm"));

    }

    public static void FormataDataAndHora() {
        DateTime data = DateTime.Now;
        Console.WriteLine($"Data: {data.ToShortDateString()} - Horas: {data.ToShortTimeString()}");
    }

    public static void PassaDataAndHora() {
        DateTime data = DateTime.Parse("25-10-2023 13:50");
        Console.WriteLine(data);
    }

    public static void DateTimeComTryParseExact() {
        string data = "25-10-2023 14:00";
        DateTime.TryParseExact(data, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNova);
        Console.WriteLine(dataNova);
    }

    public static void ValidaRetornoTryParse() {
        string data = "25-10-23 14:00";

        bool sucesso = DateTime.TryParseExact(data, "dd-MM-yy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNova);

        if (sucesso) {
            Console.WriteLine($"Data convertida com sucesso! {dataNova}");
        } else {
            Console.WriteLine($"{data} não é uma data válida");
        }
    }
    public static void Main(string[] args) {
        
    }
}