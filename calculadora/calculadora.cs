using Internal;
using System;

class Calculadora
{
    static void Main()
    {
        menu();
    }

    public static void menu()
    {
        Console.WriteLine("Escolha a operação desejada: ");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("0 - Sair");

        string escolha = Console.ReadLine();


        switch (escolha)
        {

            case "1":
                soma();
                break;

            case "2":
                sub();
                break;

            case "3":
                mult();
                break;

            case "4":
                div();
                break;

            case "0":
                Console.WriteLine("Saindo do programa");
                return;

            default:
                Console.WriteLine("Digite um opção válida");
                Console.WriteLine();
                menu();
                break;
        }



    }
    public static void soma()
    {
        double n1;
        double n2;
        Console.WriteLine("Digite o primeiro valor: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
        Console.WriteLine();
        menu();
    }

    public static void sub()
    {
        double n1;
        double n2;
        Console.WriteLine("Digite o primeiro valor: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
        Console.WriteLine();
        menu();
    }

    public static void mult()
    {
        double n1;
        double n2;
        Console.WriteLine("Digite o primeiro valor: ");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 * n2);
        Console.WriteLine();
        menu();
    }

    public static void div()
    {
        double n1;
        double n2;
        Console.WriteLine("Digite o primeiro valor: ");
        n1 = double.Parse(Console.ReadLine());
    n2:
        Console.WriteLine("Digite o segundo valor: ");
        n2 = double.Parse(Console.ReadLine());
        if (n2 == 0)
        {
            Console.WriteLine("Não é possivel dividir por zero!!");
            goto n2;
        }

        Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
        Console.WriteLine();
        menu();
    }
}