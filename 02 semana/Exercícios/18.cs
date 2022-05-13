using System;
class Principal
{
    static void Main()
    {
        int n, soma = 0, cont = 0, op = 1;
        double media;
        
        while(op != 0)
        {
            Console.WriteLine("Insira um número:");
            n = int.Parse(Console.ReadLine());

            if(n > 4)
            {
                soma += n;
                cont++;
            }
            Console.WriteLine("Pretende continuar?");
            Console.WriteLine("1 - Sim\n0 - Não?");
            op = int.Parse(Console.ReadLine());

        }

        media = soma / cont;

        if(cont > 0) 
        {
            Console.WriteLine("Média = " + media);
        }   

        else
        {
            Console.WriteLine("Não foram inseridos números maoiores que 4.");
        }                      
            Console.ReadLine();
    }
}