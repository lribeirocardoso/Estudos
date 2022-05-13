using System;
class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();

        /*nome = nome.ToLower();
        Console.WriteLine(nome);*/

        Console.WriteLine(nome.ToLower()); //não altera o valor da variável

        Console.ReadLine();
    }
}