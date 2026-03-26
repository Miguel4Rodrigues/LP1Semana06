using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ler nº de inimigos
            int numEnemies = int.Parse(args[0]);

            // Criar array
            Enemy[] enemies = new Enemy[numEnemies];

            if (enemies.Length == 0)
            {
                Console.WriteLine("Número inválido de inimigos");
                return;
            }

            // Criar inimigos
            for (int i = 0; i < numEnemies; i++)
            {
                Console.Write($"Nome do inimigo {i + 1} ");
                string name = Console.ReadLine();

                enemies[i] = new Enemy(name);
            }

            // Mostrar resultados
            Console.WriteLine();

            for (int i = 0; i < numEnemies; i++)
            {
                Console.WriteLine($"{enemies[i].GetName()} {enemies[i].GetHealth()} {enemies[i].GetShield()}");
            }

        }
    }
}
