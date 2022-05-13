using System;
class Principal
{
    static void Main()
    {
        string nome;
        double precof, precot, imposto = 0.45, revendedor = 0.28;

        Console.WriteLine("Insira  o nome do veículo:");
        nome = Console.ReadLine();
        
        Console.WriteLine("Insira  o valor de fábrica da(o) "+nome+":");
        precof = double.Parse(Console.ReadLine());
        
        precot = precof + (imposto * precof) + (revendedor * precof);

        Console.WriteLine("O valor final da(o) "+nome+" é de: "+ precot);

        Console.ReadLine();
    }
}