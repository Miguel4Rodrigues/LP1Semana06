using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Uso: RandDice <n> <s>");
                return;
            }

            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);

            Random rand = new Random(s);

            int soma = 0;

            for (int i = 0; i < n; i++)
            {
                int valor = rand.Next(1, 7);
                soma += valor;
            }

            Console.WriteLine(soma);
        }
    }
}
