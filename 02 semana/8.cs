using System;
class Principal
{
    static void Main()
    {
        int contador = 0;
        while (contador < 5)
        {
           Console.WriteLine("Rodando." + contador);
           contador = contador + 1;
        }

        do
        {
            Console.WriteLine("do while");
        }

        while(100 < 10);

        int contador2 = 0;
        do
        {
            Console.WriteLine("Do While!");
            contador2++;
        }
        while(contador2 < 5);
        
        Console.ReadLine();
    }
}