using System;
class Principal
{
    static void Main()
    {
        float n1, n2, soma;
        char opc;

        inicio:

        Console.Clear();

        Console.WriteLine("Digite o primeiro número.");
        n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número.");
        n2 = float.Parse(Console.ReadLine());

        soma = n1 + n2;

        Console.WriteLine("A soma é = "+soma);

        Console.WriteLine("Deseja realizar outra soma? [s/n]");
        opc = char.Parse(Console.ReadLine());

        if(opc == 's' || opc == 'S')
        {
            Console.Clear();
            goto inicio;
        }
        else
        {
            Console.WriteLine("Fim do programa!");
        }
        Console.ReadLine();
    }
}