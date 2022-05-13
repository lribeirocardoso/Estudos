using System;
class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();

        /*nome = nome.ToUpper();
        Console.WriteLine(nome);*/

        Console.WriteLine(nome.ToUpper()); //não altera o valor da variável

        Console.ReadLine();
    }
}