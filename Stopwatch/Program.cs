﻿using System;
using System.Threading;

namespace Stowatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo =>10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja Contar?");

            String data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1,1));
            Console.WriteLine(data);
            Console.WriteLine(type);
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
            Console.WriteLine("StopWatch Finalizado");
            Thread.Sleep(2500);
        }

    }

}
