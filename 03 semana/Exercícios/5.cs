using System;
class Principal
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();

       int pos1 = nome.IndexOf(" ");
       int pos2 = nome.IndexOf(" ", pos1+1);
       int nchar = pos2 - pos1;

        nome = nome.Remove(pos1, nchar);
        
        Console.WriteLine(nome);
           
        

        Console.ReadLine();
    }
}