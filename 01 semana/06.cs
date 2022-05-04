using System;
class Principal
{
    static void Main()
    {
        Console.WriteLine("Por favor, digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 0 && idade <= 11)
        {
            Console.WriteLine("Você é uma criança.");
        }
        else if (idade >= 12 && idade <= 18)
        {
            Console.WriteLine("Você é um adolescente.");
        }
        else if (idade >= 19 && idade <= 59)
        {
            Console.WriteLine("Você é um adulto.");
        }
        else 
        {
            Console.WriteLine("Você é um idoso.");
        }
        Console.ReadLine();
    }
}