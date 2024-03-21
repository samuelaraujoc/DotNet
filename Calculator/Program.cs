using System;

namespace Calculator
{
    class Program
    {
        static void Main(String[] args)
        {
            Subtracao();
        }
        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O Resultado da soma é " + resultado);

            Console.ReadKey();

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

        }
    }
}
