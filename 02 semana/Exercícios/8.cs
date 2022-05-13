using System;
class Principal
{
    static void Main()
    {
        int num1, num2, num3, num4;
        Console.WriteLine("Digite quatro números!");

        Console.WriteLine("1 número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("2 número: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("3 número: ");
        num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("4 número: ");
        num4 = int.Parse(Console.ReadLine());
        
        if(num1 < num2 && num1 < num3 && num1 < num4)
        {
            Console.WriteLine("O menor número é:\n"+num1);
        }

        else if(num2 < num3 && num2 < num4)
        {
            Console.WriteLine("O menor número é:\n"+num2);
        }

        else if(num3 < num4)
        {
            Console.WriteLine("O menor número é:\n"+num3);
        }

        else
        {
            Console.WriteLine("O menor número é:\n"+num4);
        }
        
            Console.ReadLine();
    }
}