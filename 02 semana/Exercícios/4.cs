using System;
class Principal
{
    static void Main()
    {
        Console.WriteLine("CÁLCULO DA ÁREA DO TRIÂNGULO\n");
        Console.Write("Digite o valor da base (b) do triângulo em m: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor da altura (h) do triângulo em m: ");
        double h = double.Parse(Console.ReadLine()); 
        double a = (b * h) / 2;
        Console.WriteLine("A área do triângulo de base "+b+" e altura "+h+" é de: "+a+" m2");
        Console.ReadLine();
    }
}