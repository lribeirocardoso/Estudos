using System;

class Principal
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        int c = 2;

        if (a < b) 
        {
             Console.WriteLine("Está correto!");
        }
        else if(a > c) 
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