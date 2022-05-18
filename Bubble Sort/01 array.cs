using System;
class Principal
{
    static int[] numeros;
    static void Main()
    {
        numeros = new int[10];
        Random rnd = new Random();

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = rnd.Next(0, 11);
        }

        Console.WriteLine("Ordem inicial:\n");
        Imprimir();

        Console.WriteLine("Ordem crescente:\n");
        OrdenarCrescente();
        Array.Sort(numeros);
        Imprimir();

        Console.WriteLine("Ordem decrescente:\n");
        OrdenarDecrescente();
        Imprimir();
    }

    private static void Imprimir()
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Posição: " + i + "\tValor: " + numeros[i]);
        }
        Console.WriteLine();
    }

    private static void OrdenarCrescente()
    {
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[i] > numeros[j])
                {
                    int aux = numeros[i];
                    numeros[i] = numeros[j];
                    numeros[j] = aux;
                }
            }
        }
    }

    private static void OrdenarDecrescente()
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[i] < numeros[j])
                {
                    int aux = numeros[i];
                    numeros[i] = numeros[j];
                    numeros[j] = aux;
                }
            }
        }
    }
}

