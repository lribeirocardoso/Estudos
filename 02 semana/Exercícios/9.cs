using System;
class Principal
{
    static void Main()
    {
        int num;
    
        Console.WriteLine("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        
        
        if(num % 2 == 0)
        {
            Console.WriteLine("O menor número "+num+" é par");
        }

        else 
        {
            Console.WriteLine("O menor número "+num+" é ímpar");
        }
            Console.ReadLine();
    }
}