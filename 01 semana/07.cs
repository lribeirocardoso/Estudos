using System;

class Principal
{
    enum Cor { Azul, Verde, Amarelo, Vermelho}
    static void Main()
    {
        Cor  corFav = Cor.Amarelo;
        Console.WriteLine(corFav);
        Console.WriteLine((int)corFav);
        Console.WriteLine((Cor)3);
        Console.ReadLine();     
    }
}