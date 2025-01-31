using System;
using System.Collections.Generic;
using System.Linq;

namespace _02PokemonDoNotGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            long sum = 0;
            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int pokemon = 0;
                if (index < 0)
                {
                    pokemon = pokemons[0];
                    sum += pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if (index >= pokemons.Count)
                {
                    pokemon = pokemons[pokemons.Count - 1];
                    sum += pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else
                {
                    pokemon = pokemons[index];
                    sum += pokemons[index];
                    pokemons.RemoveAt(index);
                }

                IncreaseOrDecrease(pokemons, pokemon);
            }

            Console.WriteLine(sum);
        }

        private static void IncreaseOrDecrease(List<int> numbers, int value)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= value)
                {
                    numbers[i] += value;
                }
                else
                {
                    numbers[i] -= value;
                }                    
            }
        }
    }
}
