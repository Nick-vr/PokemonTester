using System;

namespace PokemonTester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon charizard = new Pokemon("Charizard", 60, 78, 84, 78, 109, 85, 100);
            Console.WriteLine(charizard.Showinfo());
            charizard.LevelUp(100);
            Console.WriteLine(charizard.Showinfo());
        }
    }
}