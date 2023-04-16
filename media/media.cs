using Internal;
using System;
using System.Collections.Generic;

class Media
{
    static void Main()
    {

        List<double> numeros = new List<double>();

    inicio:
        Console.WriteLine("Quantos numeros deseja inserir? Limitado entre 3 a 10");
        int numesc = int.Parse(Console.ReadLine());
        if (numesc < 3)
        {
            Console.WriteLine("A escolha deve ser maior que 3!!");
            goto inicio;
        }
        if (numesc > 10)
        {
            Console.WriteLine("A escolha não deve ultrapassar 10!!");
            goto inicio;
        }
        else
        {
            for (int i = 0; i < numesc; i++)
            {
                Console.WriteLine("Digite o valor desejado: ");
                numeros.Add(double.Parse(Console.ReadLine()));
            }
        }

        double res1 = soma(numeros.ToArray());
        double res2 = media(numeros.ToArray());
        Console.WriteLine("------------------");

        Console.WriteLine("Soma: {0}", res1);
        Console.WriteLine("Média: {0}", res2);
    }



    public static double soma(params double[] nums)
    {
        double total = 0;

        foreach (var item in nums)
        {
            total = total + item;
        }

        return total;
    }

    public static double media(params double[] nums)
    {
        double total = 0;
        double med = 0;

        foreach (var item in nums)
        {
            total += item;
        }

        med = total / nums.Length;
        return med;
    }

}
