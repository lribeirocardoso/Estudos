using System;
class Principal
{
    static void Main()
    {
        double preco, Kg, total;
        Console.WriteLine("Preço do produto por Kg:");
        preco = double.Parse(Console.ReadLine());
        Console.WriteLine("Peso total em quilos:");

        Kg = double.Parse(Console.ReadLine()); 
        total = preco * Kg;

        Console.WriteLine("Preço total é de:\n"+total);
        Console.ReadLine();
    }
}