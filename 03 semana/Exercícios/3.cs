using System;
class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();

        nome = nome.Replace("a", "");
        nome = nome.Replace("A", "");
        nome = nome.Replace("ã", "");
        nome = nome.Replace("Ã", "");
        nome = nome.Replace("á", "");
        nome = nome.Replace("Á", "");

        Console.WriteLine(nome); 

        Console.ReadLine();
    }
}