using System;
class Principal
{
    static void Main()
    {
        int num1, num2;
        Console.WriteLine("Digite um número:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número:");
        num2 = int.Parse(Console.ReadLine()); 
        
        if(num1 < num2)
        {
            Console.WriteLine("O maior número é:\n"+num2);
        }
        else if(num1 > num2)
        {
            Console.WriteLine("O maior número é:\n"+num1);
        }
        else
        {
            Console.WriteLine("Números iguais!");
        }
            Console.ReadLine();
    }
}