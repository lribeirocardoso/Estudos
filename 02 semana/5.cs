using System;
class Principal
{
    static void Main()
    {
        string[] palavras = {"Ventilador" , "Calor" , "Sol" , "Praia"};

        for(int contador = 0; contador < palavras.Length ; contador++)
        {
            Console.WriteLine("Rodando.");
            Console.WriteLine(palavras[contador]);
        }
        Console.WriteLine("------------------------------------");

        for(int contador2 = palavras.Length-1; contador2 >= 0; contador2--)
        {
            Console.WriteLine(contador2);
            Console.WriteLine(palavras[contador2]);
        }
        Console.ReadLine();
    }
}