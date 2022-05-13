using System;
class Principal
{
    static void Main()
    {
        int num = 10;
        int num2 = 10; 

        num = num>>1;
        num2 = num2<<1;

        Console.WriteLine(num+" e "+num2);
        Console.ReadLine();
    }
}