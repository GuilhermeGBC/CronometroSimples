using System;
using System.Threading;


namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            PreStart(100);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string dados = Console.ReadLine().ToLower();
            char type = char.Parse(dados.Substring(dados.Length - 1, 1));
            int time = int.Parse(dados.Substring(0, dados.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                System.Environment.Exit(0);
            }
            PreStart(time + multiplier);
        }

        static void PreStart(int time)
        {
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");           
            Thread.Sleep(1000);
            Console.WriteLine("VAI!");
            Thread.Sleep(2500);
            Start(time);

        }

        static void Start(int time)
        {

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado... Retornando para o menu");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
