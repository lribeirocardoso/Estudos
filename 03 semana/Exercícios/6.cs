using System;
class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();

        string[] nomes = nome.Split(' '); 

        Console.WriteLine();

        Console.WriteLine("Ordem crescente");
        for(int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine(nomes[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Ordem decrescente");
        /*for(int i = nomes.Length-1; i >= 0; i--)
        {
            Console.WriteLine(nomes[i]);
        } OU*/

        Array.Reverse(nomes);
        for(int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine(nomes[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Ordem alfabética crescente");
        Array.Sort(nomes);
        for(int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine(nomes[i]);
        }
        
        Console.WriteLine();

        Console.WriteLine("Ordem alfabética decrescente");
        Array.Sort(nomes);
        Array.Reverse(nomes);
        for(int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine(nomes[i]);
        }


        Console.ReadLine();
    }
}