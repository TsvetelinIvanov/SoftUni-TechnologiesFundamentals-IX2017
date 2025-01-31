using System;
using System.Collections.Generic;
using System.Linq;

namespace _04PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> pokemons = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            int counter = 0;
            while (input != "wubbalubbadubdub")
            {
                if (input.Contains(" -> "))
                {
                    string[] pokemonData = input.Split(new string[] { " -> " }, StringSplitOptions.None);
                    string pokemonName = pokemonData[0];
                    string evolutionType = pokemonData[1];
                    long evolutionIndex = long.Parse(pokemonData[2]);
                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons.Add(pokemonName, new Dictionary<string, long>());
                    }

                    evolutionType = DoUniqueEvolutionType(evolutionType, counter);
                    counter++;

                    pokemons[pokemonName].Add(evolutionType, evolutionIndex);
                }
                else
                {
                    string pokemonName = input;
                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (KeyValuePair<string, long> evolutionData in pokemons[pokemonName])
                        {
                            string evolutionType = DoFormerEvolutionType(evolutionData.Key);
                            Console.WriteLine($"{evolutionType} <-> {evolutionData.Value}");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (KeyValuePair<string, long> evolutionData in pokemon.Value.OrderByDescending(x => x.Value))
                {
                    string evolutionType = DoFormerEvolutionType(evolutionData.Key);
                    Console.WriteLine($"{evolutionType} <-> {evolutionData.Value}");
                }
            }
        }

        private static string DoUniqueEvolutionType(string evolutionType, int counter)
        {
            string prefix = $"{counter:d10}";
            string uniqueEvolutionType = prefix + evolutionType;

            return uniqueEvolutionType;
        }

        private static string DoFormerEvolutionType(string uniqueEvolutionType)
        {
            string formerEvolutionType = uniqueEvolutionType.Substring(10);

            return formerEvolutionType;
        }        
    }
}
