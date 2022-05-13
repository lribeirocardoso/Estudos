using System;

class Principal
{
    static void Main()
    {
        if (10 > 200)
        {
             Console.WriteLine("Está correto!");
        }
        else if(23 != 22) 
        {
            Console.WriteLine("Números diferentes!");
        }
        else
        {
            Console.WriteLine("Está errado!");
        }
        Console.ReadLine();
    }
}