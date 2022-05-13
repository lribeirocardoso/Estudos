using System;
class Principal
{
    static void Main()
    {
        string[] palavras = {"Ventilador" , "Calor" , "Sol" , "Praia"};

        foreach(string palavra in palavras)
        {
            Console.WriteLine("Rodando!");
            Console.WriteLine(palavra);
        }
        Console.ReadLine();
    }
}