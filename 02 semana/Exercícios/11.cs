using System;
class Principal
{
    static void Main()
    {
        int num;
    
        Console.WriteLine("Insira o código do produto desejado:\nParafusos - 001\nPorca - 002\nPrego - 003");
        num = int.Parse(Console.ReadLine());
                
        if(num == 001)
        {
            Console.WriteLine("O código "+num+" corresponde a(ao): Parafusos");
        }

        else if (num == 002)
        {
            Console.WriteLine("O código "+num+" corresponde a(ao): Porca");
        }

        else if (num == 003)
        {
            Console.WriteLine("O código "+num+" corresponde a(ao): Prego");
        }

        else
        {
            Console.WriteLine("Não definido!");
        }  
            Console.ReadLine();
    }
}