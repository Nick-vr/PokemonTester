using System;

namespace PokemonTester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*            string pokemonName;
                        int maxLevel, hp, attack, defense, spAttack, spDefense, speed;

                        Console.WriteLine("Pokemon name?");
                        pokemonName = Convert.ToString(Console.ReadLine());

                        Console.WriteLine($"What level do you want {pokemonName} to be?");
                        maxLevel = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Base HP?");
                        hp = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Base Attack?");
                        attack = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Base Defense?");
                        defense = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Base Sp.Attack?");
                        spAttack = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Base Sp.Defense?");
                        spDefense = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Base Speed?");
                        speed = Convert.ToInt32(Console.ReadLine());

                        Pokemon pokemon = new Pokemon(pokemonName, maxLevel, hp, attack, defense, spAttack, spDefense, speed);
                        pokemon.LevelUp(maxLevel);
                        Console.WriteLine(pokemon.Showinfo());*/

            Pokemon newpoke = GeneratorPokemon();
            if (newpoke != null)
            {
                Console.WriteLine(newpoke.Showinfo());
            }
        }

        private static Pokemon GeneratorPokemon()
        {
            int hp, attack, defense, spAttack, spDefense, speed;

            Random rnd = new Random();

            hp = Convert.ToInt32(rnd.Next(45, 100));
            attack = Convert.ToInt32(rnd.Next(45, 100));
            defense = Convert.ToInt32(rnd.Next(45, 100));
            spAttack = Convert.ToInt32(rnd.Next(45, 100));
            spDefense = Convert.ToInt32(rnd.Next(45, 100));
            speed = Convert.ToInt32(rnd.Next(45, 100));

            Pokemon newPokemon = new Pokemon(hp, attack, defense, spAttack, spDefense, speed);

            return newPokemon;
        }
    }
}