using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Cria uma instância da classe Nokia
        Smartphone nokia = new Nokia("123456", "Modelo A", "111111111", 64);
        
        // Testando os métodos da classe Nokia
        Console.WriteLine("Teste com Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        Console.WriteLine($"Número: {nokia.Numero}, Modelo: {nokia.Modelo}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}GB");
        Console.WriteLine();

        // Cria uma instância da classe Iphone
        Smartphone iphone = new Iphone("654321", "Modelo X", "222222222", 128);
        
        // Testando os métodos da classe Iphone
        Console.WriteLine("Teste com iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
        Console.WriteLine($"Número: {iphone.Numero}, Modelo: {iphone.Modelo}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}GB");
    }
}