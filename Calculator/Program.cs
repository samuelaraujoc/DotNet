using System;

namespace Calculator
{
    class Program
    {
        static void Main(String[] args)
        {
            Multiplicacao();
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

        static void Soma (){

             Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da Subtração é: " + resultado);

            Console.ReadKey();
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

        }


    }

}
