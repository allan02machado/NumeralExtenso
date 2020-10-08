using System;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string numeroPorExtenso = numero.ToWords();
            Console.WriteLine($"O número {numero} em extenso fica: {numeroPorExtenso}");
        }
    }
}
