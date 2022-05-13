using System;
class Principal
{
    static Random rnd = new Random();
    static string nome = "";
    static int saldo = 100;

    static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        nome = Console.ReadLine();

        int op = 1;
        while(op != 0)
        {
            Console.Clear();
            Console.WriteLine("Seja bem-vindo(a), "+nome+"!\nSeu saldo é de: "+saldo+"");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Loteria");
            Console.WriteLine("2 - Raspadinhas");
            Console.WriteLine("3 - Levantamentos / Depósitos");
            Console.WriteLine("0 - Sair");
            op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 0:
                break;

                case 1:
                Loteria();
                break;

                case 2:
                Raspadinhas();
                break;

                case 3:
                Banca();
                break;

                default:
                Console.WriteLine("Opção inválida, favor inserir outra.");
                Console.ReadKey();
                break;
            }
        }
        Console.ReadLine();
    }

    private static void Loteria()
    {
        Console.Clear();

        if(saldo - 5 < 0)
        {
            Console.WriteLine("Saldo insuficiente, favor realizar um depósito.");
            Console.ReadKey();
            return;
        }
        saldo -= 5;

        int npremiado = rnd.Next(1000, 10000);
        int njogador = 0;

        while(njogador < 1000 || njogador > 9999)
        {
            Console.WriteLine("Qual número deseja jogar na Loteria? (entre 1000 - 9999)");
            njogador = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Bilhete premiado: "+npremiado);

        if(npremiado == njogador)
        {
            Console.WriteLine("Parabéns, você foi o grande premiado!");
            saldo += 10000;
        }

        else if(npremiado % 1000 == njogador % 1000)
        {
            Console.WriteLine("Parabéns, você  ganhou o segundo prêmio!");
            saldo += 1000;
        }

        else if(npremiado % 100 == njogador % 100)
        {
            Console.WriteLine("Parabéns, você  ganhou o terceiro prêmio!");
            saldo += 100;
        }

        else
        {
            Console.WriteLine("O seu bilhete não foi premiado!");
        }
        Console.ReadKey();

    }
    private static void Raspadinhas()
    {
        int op = 1;

        while(op != 0)
        {
            Console.Clear();
            Console.WriteLine("Menu: Raspadinhas");
            Console.WriteLine("1 - Raspadinhas A");
            Console.WriteLine("2 - Raspadinhas B");
            Console.WriteLine("0 - Voltar ao menu principal");
            op = int.Parse(Console.ReadLine());

            if(op == 0)
            {
                break;
            }

            else if(op == 1)
            {
                RaspadinhasA();
            }

            else if(op == 2)
            {
                RaspadinhasB();
            }

            else
            {
                Console.WriteLine("Opção inválida, favor inserir outra.");
                Console.ReadKey();
            }
        }
    }

     private static void RaspadinhasA()
    {
        Console.Clear();

           if(saldo - 2 < 0)
        {
            Console.WriteLine("Saldo insuficiente, favor realizar um depósito.");
            Console.ReadKey();
            return;
        }
        saldo -= 2;
        
        int nprincipal = rnd.Next(1, 10);
        int n1 = rnd.Next(1, 10);  int p1 = rnd.Next(1, 100);
        int n2 = rnd.Next(1, 10);  int p2 = rnd.Next(1, 100);
        int n3 = rnd.Next(1, 10);  int p3 = rnd.Next(1, 100);
        int n4 = rnd.Next(1, 10);  int p4 = rnd.Next(1, 100);
        int n5 = rnd.Next(1, 10);  int p5 = rnd.Next(1, 100);

        Console.WriteLine("Número princiapl: "+nprincipal);
        Console.WriteLine("Primeiro número: "+n1+" ("+p1+")");
        Console.WriteLine("Segundo número: "+n2+" ("+p2+")");
        Console.WriteLine("Terceiro número: "+n3+" ("+p3+")");
        Console.WriteLine("Quarto número: "+n4+" ("+p4+")");
        Console.WriteLine("Quinto número: "+n5+" ("+p5+")");

        int premio = 0;

        if(n1 == nprincipal) premio += p1;
        if(n2 == nprincipal) premio += p2;
        if(n3 == nprincipal) premio += p3;
        if(n4 == nprincipal) premio += p4;
        if(n5 == nprincipal) premio += p5;

        Console.WriteLine("Prêmio: "+premio);
        saldo += premio;

        Console.ReadKey();
     }

    private static void RaspadinhasB()
    {
        Console.Clear();

           if(saldo - 2 < 0)
        {
            Console.WriteLine("Saldo insuficiente, favor realizar um depósito.");
            Console.ReadKey();
            return;
        }
        saldo -= 2;

        int nprincipal = rnd.Next(1, 10);
        int premio = rnd.Next(1, 100);

        int n1 = rnd.Next(1, 10);
        int n2 = rnd.Next(1, 10);
        int n3 = rnd.Next(1, 10);
        int n4 = rnd.Next(1, 10);
        int n5 = rnd.Next(1, 10);
        int n6 = rnd.Next(1, 10);
        int n7 = rnd.Next(1, 10);
        int n8 = rnd.Next(1, 10);
        int n9 = rnd.Next(1, 10);

        int cont = 0;

        if(nprincipal == n1) cont++;
        if(nprincipal == n2) cont++;
        if(nprincipal == n3) cont++;
        if(nprincipal == n4) cont++;
        if(nprincipal == n5) cont++;
        if(nprincipal == n6) cont++;
        if(nprincipal == n7) cont++;
        if(nprincipal == n8) cont++;
        if(nprincipal == n9) cont++;

        Console.WriteLine("Número principal: "+nprincipal+" ("+premio+")");
        Console.WriteLine(n1+ " "+n2+ " "+n3);
        Console.WriteLine(n4+ " "+n5+ " "+n6);
        Console.WriteLine(n7+ " "+n8+ " "+n9);

        if(cont >=3)
        {
            Console.WriteLine("Parabéns, raspadinha premiada!\nGanhou "+premio);
            saldo += premio;
        }

        else
        {
            Console.WriteLine("Raspadinha não premiada");
        }
        Console.ReadKey();
    }

    private static void Banca()
    {
        int op = 1;
        while(op != 0)
        {
            Console.Clear();
            Console.WriteLine("Seja bem vindo(a) à sua Banca!\nSaldo disponível de: "+saldo);
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Depósito");
            Console.WriteLine("0 - Voltar ao menu anterior");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 0:
                break;

                case 1:
                Saque();
                break;

                case 2:
                Deposito();
                break;
                
                default:
                Console.WriteLine("Opção inválida, tente novamente.");
                Console.ReadKey();
                break;
            }
        }
    }

    private static void Deposito()
    {
        Console.Clear();
        Console.WriteLine("Saldo atual: "+saldo);
        Console.WriteLine("Quanto deseja depositar em sua conta?");
        int valor = int.Parse(Console.ReadLine());

        saldo += valor;

        Console.WriteLine("Depósito realizado com sucesso!");
        Console.WriteLine("Saldo atual: "+saldo);

        Console.ReadKey();
    }
     private static void Saque()
    {
        Console.Clear();
        Console.WriteLine("Saldo atual: "+saldo);
        Console.WriteLine("Quanto deseja sacar de sua conta?");
        int valor = int.Parse(Console.ReadLine());

        if(saldo - valor < 0)
        {
            Console.WriteLine("Saldo insuficiente.");
        }

        else
        {
            saldo -= valor;

            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine("Saldo atual: "+saldo);
        }
        Console.ReadKey();
    }
}