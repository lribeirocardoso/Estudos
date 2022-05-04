using System;
class Principal
{
    static void Main()
    {       
        string cor = "rosa";

        switch(cor)   
        {
            case "Vermelho":
                Console.WriteLine("Sua cor é vermelho!");
                break;
            case "Azul":
                Console.WriteLine("Sua cor é azul!");
                break;
            case "Amarelo":
            Console.WriteLine("Sua cor é Amarelo!");
                break;
            default:
            Console.WriteLine("Não conheço esta cor!");
                break;
        }
        Console.ReadLine();
    }
}