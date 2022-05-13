using System;
class Principal
{
    static void Main()
    {
        double num, soma = 0, media, cont = 0, n = 10; 
    
        Console.WriteLine("Insira 10 números abaixo para obter a sua média:\n");
                        
        while(cont < n)
        {
            Console.Write("Número: ");
            num = double.Parse(Console.ReadLine());

           soma += num; 
           
           cont++;
        }
        
        media = soma / n;

        Console.WriteLine("Média: "+media);
        Console.ReadLine();
    }
}