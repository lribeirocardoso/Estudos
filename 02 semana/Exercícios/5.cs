using System;
class Principal
{
    static void Main()
    {
        Console.WriteLine("Valor pago pelo cliente:");
        double vpago = double.Parse(Console.ReadLine());
        Console.WriteLine("Valor do produto:");
        double vproduto = double.Parse(Console.ReadLine()); 
        double troco = vpago - vproduto;

        if(troco > 0)
        {
            Console.WriteLine("Troco de:\n"+troco);
        }
        else if(troco < 0)
        {
            Console.WriteLine("O cliente deve:\n"+Math.Abs(troco));
        }
        else
        {
            Console.WriteLine("Ok");

        }
        Console.ReadLine();
    }
}