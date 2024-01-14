using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nSmartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "999999999", modelo: "G11", imei: "999999999", memoria: 128);
        nokia.Ligar();
        nokia.InstalarAplicativo("Waze");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone iPhone:");
        Smartphone iphone = new Iphone(numero: "888888888", modelo: "15 Pro", imei: "888888888", memoria: 256);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("\n");
    }
}
