using System;
class Principal
{
    static void Main()
    {
        int l1, l2, l3;
    
        Console.WriteLine("Insira o valor do lado 1: ");
        l1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o valor do lado 2: ");
        l2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o valor do lado 3: ");
        l3 = int.Parse(Console.ReadLine());
        
        if(l1 == 0 || l2 == 0 || l3 == 0)
        {
            Console.WriteLine("Possui ao menos um dos lados igual a 0, portanto não é um triângulo.");
        }

        else if (l1 > l2 + l3 || l2 > l1 + l3 || l3 > l1 + l2)
        {
            Console.WriteLine("Não é possível, pois um dos lados é maior que a soma dos outros dois.");
        }

        else if (l1 == l2  && l1 == l3)
        {
            Console.WriteLine("Triângulo equilátero.");
        }

        else if ((l1 == l2 && l1 != l3) || (l2 == l3 && l2 != l1) || (l1 == l3 && l1 != l2))
        {
            Console.WriteLine("Triângulo isósceles.");
        }

        else if (l1 != l2  && l1 != l3 && l2 != l3)
        {
            Console.WriteLine("Triângulo escaleno.");
        }
            Console.ReadLine();
    }
}