using System;
class Principal
{
    static void Main()
    {
        int op = 1;
        
        while(op != 0)
        {
            Console.Clear();
            Console.WriteLine("Seja bem-vindo!\nEscolha uma das opções abaixo:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("0 - Sair");
            op = int.Parse(Console.ReadLine());

            if(op == 0)
            {
                break;
            }

            else if(op == 1)
            {
                Somar();
            }

             else if(op == 2)
            {
                Subtrair(); 
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida.");
                Console.ReadKey();
            }
        }             
              Console.ReadLine();
    }

    private static void Somar()
    {
        Console.Clear();
        Console.WriteLine("Digite um número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro número:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(+num1+ "+" +num2+ "=" +(num1 + num2));
        Console.ReadKey();
    }
    private static void Subtrair()
    {
        Console.Clear();
        Console.WriteLine("Digite um número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro número:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(+num1+ "-" +num2+ "=" +(num1 - num2));
        Console.ReadKey();
    }

}