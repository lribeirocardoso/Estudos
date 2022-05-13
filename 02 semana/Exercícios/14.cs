using System;
class Principal
{
    static void Main()
    {
        double num, soma = 0, media, cont, n = 10; 
    
        Console.WriteLine("Insira 10 números abaixo para obter a sua média:\n");
                        
        for(cont = 1; cont <= n; cont++)
        {
            Console.Write("Número "+cont+": ");
            num = double.Parse(Console.ReadLine());

           soma += num; 
        }
        
        media = soma / n;

        Console.WriteLine("Média: "+media); 
        Console.ReadLine();
    }
}