using System;

namespace Calculator
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O Resultado da soma é " + resultado);
        }
    }
}
