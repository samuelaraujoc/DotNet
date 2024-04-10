using System;

namespace Calculator
{
    class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("1 - Subtração");
            Console.WriteLine("2 - Soma");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------------");
            Console.WriteLine("Seleciona uma Opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Subtracao (); break;
                case 2: Soma (); break;
                case 3: Divisao (); break;
                case 4: Multiplicacao (); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu (); break;
            }

        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine("O resultado da Subtração é: " + resultado);

            Console.ReadKey();

            Menu();

        }

        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da Subtração é: " + resultado);

            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine("O Resultado da divisão é: " + resultado);

            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine("O Resultado da divisão é: " + resultado);

            Console.ReadKey();

            Menu();

        }
    }

}
