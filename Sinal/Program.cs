using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.Write("Digite um número: ");
            valor = int.Parse(Console.ReadLine());

            if (valor > 0)
            {
                Console.WriteLine("Você digitou um número positivo!");
            }
            else if (valor < 0)
            {
                Console.WriteLine("Você digitou um número negativo");
            }
            else
            {
                Console.WriteLine("Você digitou zero");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
