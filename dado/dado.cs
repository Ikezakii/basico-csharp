using Internal;
using System;

class Dado
{
    static void Main()
    {
    //int pontrod = 0;
    j1:
        Console.WriteLine("Digite o nome do primeiro jogador: ");
        string n1 = Console.ReadLine();
        if (n1 == "")
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Digite um nome valido! ");
            Console.WriteLine("--------------");
            goto j1;
        }
        Jogador j1 = new Jogador(n1);

    j2:
        Console.WriteLine("Digite o nome do segundo jogador: ");
        string n2 = Console.ReadLine();
        if (n2 == "")
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Digite um nome valido! ");
            Console.WriteLine("--------------");
            goto j2;
        }
        if (n1.ToUpper() == n2.ToUpper())
        {
            Console.WriteLine("--------------");
            Console.WriteLine("O nome dos jogadores não podem ser iguais!");
            Console.WriteLine("--------------");
            goto j2;
        }
        Jogador j2 = new Jogador(n2);
        int[] ex1 = new int[3];
        int[] ex2 = new int[3];
        Random rand = new Random();

        for (int i = 1; i <= 3; i++)
        {

            Console.WriteLine("=======================");
            Console.WriteLine("Pressione ENTER para começar a rodada numero {0}", i);
            Console.ReadLine();
            Console.WriteLine("");
            j1.dado = rand.Next(1, 7);
            j2.dado = rand.Next(1, 7);
            ex1[i - 1] = j1.dado;
            ex2[i - 1] = j2.dado;

            Console.WriteLine("{0} tirou o numero {1}", j1.nome, j1.dado);
            Console.WriteLine("{0} tirou o numero {1}", j2.nome, j2.dado);
            Console.WriteLine("---");

            if (j1.dado > j2.dado)
            {
                Console.WriteLine("{0} ganhou a rodada numero {1}", j1.nome, i);
                j1.pontos++;
                Console.WriteLine("PLACAR -> {0}:{1} x {2}:{3}", j1.nome, j1.pontos, j2.pontos, j2.nome);
            }
            else if (j1.dado == j2.dado)
            {
                Console.WriteLine(" A rodada numero {0} terminou em EMPATE - Nenhum jogador pontuou", i);
                Console.WriteLine("PLACAR -> {0}:{1} x {2}:{3}", j1.nome, j1.pontos, j2.pontos, j2.nome);
            }
            else
            {
                Console.WriteLine("{0} ganhou a rodada numero {1}", j2.nome, i);
                j2.pontos++;
                Console.WriteLine("PLACAR -> {0}:{1} x {2}:{3}", j1.nome, j1.pontos, j2.pontos, j2.nome);
            }
        }
        if (j1.pontos > j2.pontos)
        {
            Console.WriteLine("=======================");
            Console.WriteLine("{0}:{1} x {2}:{3}", j1.nome, j1.pontos, j2.pontos, j2.nome);
            Console.WriteLine("{0} ganhou a partida", j1.nome);
            Console.WriteLine("=======================");
        }
        else if (j1.pontos == j2.pontos)
        {
            Console.WriteLine("=======================");
            Console.WriteLine("{0}:{1} x {2}:{3}", j1.nome, j1.pontos, j2.pontos, j2.nome);
            Console.WriteLine("A partida empatou");
            Console.WriteLine("=======================");
        }
        else
        {
            Console.WriteLine("=======================");
            Console.WriteLine("{0}:{1} x {2}:{3}", j1.nome, j1.pontos, j2.pontos, j2.nome);
            Console.WriteLine("{0} ganhou a partida", j2.nome);
            Console.WriteLine("=======================");
        }

        for (int i = 0; i < ex1.Length; i++)
        {
            Console.WriteLine("valores do jogador 1: {0}", ex1[i]);
        }
        Console.WriteLine("--------------");
        for (int i = 1; i <= ex2.Length; i++)
        {
            Console.WriteLine("valores do jogador 2: {0}", ex2[i - 1]);
        }
    }


}




public class Jogador
{
    public string nome;
    public int pontos;
    public int dado;

    public Jogador(string nome)
    {
        this.nome = nome;
        pontos = 0;
        dado = 0;
    }
}