using System;
class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();

        while(nome.Length > 0)
        {
            Console.WriteLine("Qual letra deseja retirar?");
            string letra = Console.ReadLine();

            nome = nome.Replace(letra, "");
            nome = nome.Trim();
            Console.WriteLine(nome);
        }

        Console.ReadLine();
    }
}