using System;
using System.Collections.Generic;
using System.Linq;

namespace _07PopulationCounter
{
    class Program
    {        
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "report")
            {
                string[] populationData = input.Split('|');
                string country = populationData[1];
                string city = populationData[0];
                long population = long.Parse(populationData[2]);

                if (!countries.ContainsKey(country))
                {
                    countries[country] = new Dictionary<string, long>();
                }

                if (!countries[country].ContainsKey(city))
                {
                    countries[country].Add(city, population);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> country in countries.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (KeyValuePair<string, long> city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
