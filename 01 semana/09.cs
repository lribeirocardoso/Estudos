using System;

namespace HelloWorld
{
    class Principal
    {
        static void Main()
        {
            int soma = Soma(2, 8, 12);
            int soma1 = Soma(3, 20, -1);
           Console.WriteLine(soma);
           Console.WriteLine(soma);
            Console.ReadLine();
        }
        static void GerarPreco(int preco)
        {
            int precoabs = Math.Abs(preco); 
            int ValorFinal = precoabs + (2 * precoabs);
            Console.WriteLine("Valor final: " + ValorFinal);
        }
        static int Soma(int a, int b, int c)
        {
            int resultado = a + b + c;
            return resultado;
        }
        Console.ReadLine();
    }
}