using System;
using Internal;
using System.Collections.Generic;

namespace datas
{
    class Data
    {
        static void Main()
        {
            var data = new Dataconfiguracao();
            data.menuformato();
            data.menuanime();
        }
    }

    internal class Dataconfiguracao
    {
        private byte formato;
        public Dataconfiguracao()
        {
            formato = 1;
        }

        private List<DateTime> Animes
        {
            get
            {
                return new List<DateTime>()
        {
            new DateTime(2014,10,12),
            new DateTime(2003,10,10),
            new DateTime(2007,12,07)
        };
            }
        }

        public void menuformato()
        {
            Console.Clear();
        formato:
            DateTime dataatual = DateTime.Now;
            Console.WriteLine("Informe o formato de data que deseja usar:");
            Console.WriteLine("1 - Sistema: {0}", dataatual.ToString());
            Console.WriteLine("2 - Simples: {0}", string.Format("{0:dd-MM-yy}", dataatual));
            Console.WriteLine("3 - Longo: {0}", dataatual.ToLongDateString());
            Console.WriteLine("4 - Longo personalizado: {0}", string.Format("{0:dd-MM-yyyy hh:mm:ss}", dataatual));
            Console.WriteLine("5 - RFC1123 pattern: {0}", string.Format("{0:r}", dataatual));


            var escolha = byte.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    formato = escolha;
                    break;

                default:
                    Console.WriteLine("Digite um opção válida");
                    goto formato;
            }
        }
        private string formatacao(DateTime data)
        {
            string dataformatada;
            switch (formato)
            {
                case 1:

                    dataformatada = data.ToString();
                    break;

                case 2:

                    dataformatada = string.Format("{0:dd-MM-yy}", data);
                    break;

                case 3:

                    dataformatada = data.ToLongDateString();
                    break;

                case 4:

                    dataformatada = string.Format("{0:dd-MM-yyyy hh:mm:ss}", data);
                    break;

                case 5:

                    dataformatada = string.Format("{0:r}", data);
                    break;

                default:
                    dataformatada = data.ToString();
                    break;
            }
            return dataformatada;
        }
        private void cabecalho(byte animeesc)
        {
            DateTime dataesc = Animes[animeesc - 1];
            string dataformatada = formatacao(dataesc);

            Console.WriteLine(dataformatada);
        }
        public void menuanime()
        {

            Console.WriteLine("Selecione o Anime");
            Console.WriteLine("1 - Fate/stay night: Unlimited Blade Works");
            Console.WriteLine("2 - Shingetsutan Tsukihime");
            Console.WriteLine("3 - Kara no Kyoukai: Fukan Fuukei");
            Console.WriteLine("Pressione qualuqer outra tecla para sair");

            var animeesc = byte.Parse(Console.ReadLine());

            switch (animeesc)
            {

                case 1:
                    Console.Clear();
                    cabecalho(animeesc);
                    Console.WriteLine("Melhor Fate de todos da linha 'Stay / Night', Toosaka best girl <3");
                    Console.WriteLine("------------");
                    break;

                case 2:
                    Console.Clear();
                    cabecalho(animeesc);
                    Console.WriteLine("Anime que no começo eu não achei a pior coisa do mundo, mas depois de jogar a novel MEUDEUS que anime ruim");
                    Console.WriteLine("------------");
                    break;

                case 3:
                    Console.Clear();
                    cabecalho(animeesc);
                    Console.WriteLine("Nem muito bom, nem muito ruim...É legal mas sei la, estranho ao mesmo tempo");
                    Console.WriteLine("------------");
                    break;

                default:
                    return;
            }
            menuanime();
        }



    }
}









