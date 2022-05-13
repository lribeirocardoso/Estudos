using System;
class Principal
{
    enum DiasSemana{Segunda, Terça, Quarta, Quinta, Sexta, Sábado, Domingo};
    static void Main()
    {
        DiasSemana diasS= DiasSemana.Domingo;
        DiasSemana dia = (DiasSemana)2;
        int ds = (int)DiasSemana.Segunda;

        Console.WriteLine(diasS);
        Console.WriteLine(dia);
        Console.WriteLine(ds);
                
        Console.ReadLine();
    }
}