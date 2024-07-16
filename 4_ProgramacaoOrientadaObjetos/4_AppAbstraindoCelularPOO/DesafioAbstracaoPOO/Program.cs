using System;
using DesafioAbstracaoPOO.Models;

public class Program {
    public static void Main(string[] args) {
        
        Nokia nokia = new Nokia("62995687845", "Nokia-23", "12345678910", 32);
        nokia.Ligar();
        nokia.InstalarAplicativo("VirusDark");
        Console.WriteLine(nokia.ToString());
                
        Iphone iphone = new Iphone("62995647596", "Iphone-XS", "2349485876", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Destroyer");
        Console.WriteLine(iphone.ToString());
    }
}