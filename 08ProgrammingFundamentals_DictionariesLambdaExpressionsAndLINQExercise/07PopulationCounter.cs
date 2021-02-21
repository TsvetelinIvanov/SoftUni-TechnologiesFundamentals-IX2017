using System;
using System.Collections.Generic;
using System.Linq;

namespace _07PopulationCounter
{
    class Program
    {        
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> coutries = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "report")
            {
                string[] populationData = input.Split('|');
                string country = populationData[1];
                string city = populationData[0];
                long population = long.Parse(populationData[2]);

                if (!coutries.ContainsKey(country))
                {
                    coutries[country] = new Dictionary<string, long>();
                }

                if (!coutries[country].ContainsKey(city))
                {
                    coutries[country].Add(city, population);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> country in coutries.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (KeyValuePair<string, long> city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
