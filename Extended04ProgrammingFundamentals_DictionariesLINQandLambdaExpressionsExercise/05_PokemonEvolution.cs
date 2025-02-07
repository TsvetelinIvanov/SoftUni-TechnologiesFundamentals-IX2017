using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_PokemonEvolution
{
    class Evolution
    {
        public string Type { get; set; }
        
        public long Index { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Evolution>> pokemons = new Dictionary<string, List<Evolution>>();
            string input = Console.ReadLine();
            while (input != "wubbalubbadubdub")
            {
                string[] pokemonData = input.Split(new string[] { " -> " }, StringSplitOptions.None);
                string pokemonName = pokemonData[0];
                if (pokemonData.Length > 1)
                {
                    string evolutionType = pokemonData[1];
                    long evolutionIndex = long.Parse(pokemonData[2]);

                    Evolution evolution = new Evolution();
                    evolution.Type = evolutionType;
                    evolution.Index = evolutionIndex;

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new List<Evolution>();
                    }

                    pokemons[pokemonName].Add(evolution);
                }
                else
                {
                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (Evolution evolution in pokemons[pokemonName])
                        {
                            Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<Evolution>> pokemon in pokemons)
            {
                Console.WriteLine("# {0}", pokemon.Key);
                foreach (Evolution evolution in pokemon.Value.OrderByDescending(e => e.Index))
                {
                    Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                }
            }
        }
    }
}
