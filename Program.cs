using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Quantos numero voce quer digitar ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"valor {0}");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;

            }
            Console.WriteLine("soma = " + soma);
        }
    }
}

