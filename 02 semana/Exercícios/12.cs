using System;
class Principal
{
    static void Main()
    {
        int num;
    
        Console.WriteLine("Insira o código do produto desejado:\nParafusos - 001\nPorca - 002\nPrego - 003");
        num = int.Parse(Console.ReadLine());
                
        switch(num)
        {
            case 001:
            Console.WriteLine("O código "+num+" corresponde a(ao): Parafusos");
            break;

            case 002:
            Console.WriteLine("O código "+num+" corresponde a(ao): Porca");
            break;

            case 003:
            Console.WriteLine("O código "+num+" corresponde a(ao): Prego");
            break;

            default:
            Console.WriteLine("Não definido!");
            break;
    
        }
            Console.ReadLine();
    }
}