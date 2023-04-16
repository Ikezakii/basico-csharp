using System;
using Internal;

class Paifilho
{
    static void Main()
    {
        Pai hei = new Pai();
        Filho tekken = new Filho("Kazuya", 24, "d/f+3, 2, 1");
        Console.WriteLine("{0} {1} - {2}", hei.nome, hei.obtersn(), hei.idade);
        Console.WriteLine("{0} {1} - {2} - {3}", tekken.nome, tekken.obtersn(), tekken.idade, tekken.input);
    }

}

public class Pai
{
    public string nome = "";
    protected string sobrenome = "Mishima";
    public int idade;
    public Pai()
    {
        nome = "Heihachi";
        idade = 40;
    }
    public virtual string obtersn()
    {
        return sobrenome;
    }
}

public class Filho : Pai
{
    public string input = "";
    public Filho(string n, int id, string input)
    {
        nome = n;
        idade = id;
        this.input = input;

    }
    public override string obtersn()
    {
        return sobrenome;
    }

}