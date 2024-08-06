using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavrasPalindromos = new string[] { "ovo", "osso", "pop", "ele" };
            string separador = new string('-', 25);
            string palavra;

            Console.WriteLine(separador);
            Console.WriteLine("Palavras Palíndromos");
            Console.WriteLine(separador);
            Console.WriteLine("");

            Console.WriteLine("Informe se a palavra é um Palíndromo ou não:");
            palavra = Console.ReadLine();
            if (palavrasPalindromos[0] == palavra)
            {
                Console.WriteLine("É um palíndromo");
            }
            else if (palavrasPalindromos[1] == palavra)
            {
                Console.WriteLine("É um palíndromo");
            }
            else if (palavrasPalindromos[2] == palavra)
            {
                Console.WriteLine("É um palíndromo");
            }
            else if (palavrasPalindromos[3] == palavra)
            {
                Console.WriteLine("É um palíndromo");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo");
            }

        }
    }
}
