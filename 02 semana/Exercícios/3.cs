using System;
class Principal
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        int num2 = int.Parse(Console.ReadLine()); 
        int dif = num1 - num2;
        Console.WriteLine("A diferença entre "+num1+" e "+num2+" é de: " + dif);
        Console.ReadLine();
    }
}