
using System.Collections;

public class Program {
    public static void Preenche_Array_Numeros_Aleatorios () {
        Random aleatorio = new Random();
        
        int[] array_inteiros = new int[4];

        for (int i = 0; i < array_inteiros.Length; i++) {
            int numero_aleatorio = aleatorio.Next(1, 99);
            array_inteiros[i] = numero_aleatorio;
            Console.WriteLine($"Posição {i}: {numero_aleatorio}");
        }

    }

    public static void Preenche_Array_Numeros_Aleatorios_Com_Foreach () {
        Random aleatorio = new Random();
        
        int[] array_inteiros = new int[4];
        
        int posicao = 0;
        foreach (int numero in array_inteiros) {
            
            int numero_aleatorio = aleatorio.Next(1, 99);
            array_inteiros[numero] = numero_aleatorio;
            Console.WriteLine($"Posição {posicao}: {numero_aleatorio}");
            posicao++;

        }
    }

    
    public static void Redimensiona_Array_Inteiros () {
        int[] array_inteiros = new int[4];
        Random aleatorios = new Random();

        Console.WriteLine("### Array Antes do Resize ###");
        for (int i = 0; i < array_inteiros.Length; i++) {
            array_inteiros[i] = aleatorios.Next(1, 99);
            Console.WriteLine(array_inteiros[i]);
        }

        Array.Resize(ref array_inteiros, array_inteiros.Length * 2);
        Console.WriteLine("### Array Antes do Resize ###");
        for (int i = 0; i < array_inteiros.Length; i++) {
            array_inteiros[i] = aleatorios.Next(1, 99);
            Console.WriteLine(array_inteiros[i]);
        }


    } 

    public static void Copia_Array_E_Dobra () {
        int[] array_inteiros = new int[4];
        Random aleatorios = new Random();

        Console.WriteLine("### ARRAY ANTES DE CÓPIA E DOBRAR ###");
        for (int i = 0; i < array_inteiros.Length; i++) {
            array_inteiros[i] = aleatorios.Next(1, 99);
            Console.WriteLine(array_inteiros[i]);
        }
        
        int[] array_dobrado = new int[array_inteiros.Length * 2];
        Array.Copy(array_inteiros, array_dobrado, array_inteiros.Length); 


        Console.WriteLine("### ARRAY APÓS CÓPIA E DOBRAR ###");
        for (int i = 0; i < array_dobrado.Length; i++) {
            array_dobrado[i] = aleatorios.Next(1, 99);
            Console.WriteLine(array_dobrado[i]);
        }

    }

    public static void Percorre_Lista_Estados () {
               List<string> lista_string = new List<string>();
        lista_string.Add("GO");
        lista_string.Add("DF");
        lista_string.Add("SP");

        Console.WriteLine("Percorrendo lista com for");
        for (int i = 0; i < lista_string.Count; i++) {
            Console.WriteLine($"Posição {i} = {lista_string[i]}");
        }

        Console.WriteLine("\nPercorrendo lista com foreach");
        
        int contador = 0;
        foreach (string valor in lista_string) {
            Console.WriteLine($"Posição {contador} = {lista_string[contador]}");
            contador++;
        }
    }

    public static void Manipula_Itens_E_Capacidade_Estados() {

    }
    public static void Main (string[] args) {
        List<string> lista_string = new List<string>();
        lista_string.Add("GO");
        lista_string.Add("SP");
        lista_string.Add("RJ");
        lista_string.Add("MG");

        Console.WriteLine($"Itens na minha lista: {lista_string.Count} - Capacidade da lista: {lista_string.Capacity}");

        Console.WriteLine("Adicionando Bahia (BA)");
        lista_string.Add("BA");

        Console.WriteLine($"Itens na minha lista: {lista_string.Count} - Capacidade da lista: {lista_string.Capacity}");


        Console.WriteLine("Removendo Rio de Janeiro (RJ)");
        lista_string.Remove("RJ");

        Console.WriteLine($"Itens na minha lista: {lista_string.Count} - Capacidade da lista: {lista_string.Capacity}");

        foreach(string item in lista_string) {
            Console.WriteLine(item);
        }

  
    }    
    
}

