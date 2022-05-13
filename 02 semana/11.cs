using System;
class Principal
{
    enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
    static void Main()
    {
        Console.WriteLine("Selecione uma das opções abaixo: ");
        Console.WriteLine("1 - Criar\n2 - Deletar\n3 - Editar\n4 - Listar\n5 - Atualizar");
        int index = int.Parse(Console.ReadLine());
        Opcao opcaoSelecionada = (Opcao)index;

        switch (opcaoSelecionada)
        {
            case Opcao.Criar:
            Console.WriteLine("O que deseja criar?");
            break;
            case Opcao.Deletar:
            Console.WriteLine("Delete.");
            break;
            case Opcao.Editar:
            Console.WriteLine("Clique para iniciar a edição.");
            break;
            case Opcao.Listar:
            Console.WriteLine("Comece a digitar para iniciar a sua listagem");
            break;
            case Opcao.Atualizar:
            Console.WriteLine("Atualizando...");
            break;
            default:
            Console.WriteLine("Opção não encontrada.");
            break;
        }
        Console.ReadLine();
    }
}