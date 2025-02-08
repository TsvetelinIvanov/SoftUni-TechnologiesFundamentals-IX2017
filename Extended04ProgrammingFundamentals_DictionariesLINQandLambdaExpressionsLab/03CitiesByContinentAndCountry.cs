using System;
using System.Collections.Generic;

namespace _03CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int dataPiecesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> citiesByCountriesAndContinents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < dataPiecesCount; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string continent = data[0];
                string country = data[1];
                string city = data[2];
                
                if (!citiesByCountriesAndContinents.ContainsKey(continent))
                {
                    citiesByCountriesAndContinents.Add(continent, new Dictionary<string, List<string>>());
                    //citiesByCountriesAndContinents[continent] = new Dictionary<string, List<string>>();
                }

                if (!citiesByCountriesAndContinents[continent].ContainsKey(country))
                {
                    citiesByCountriesAndContinents[continent].Add(country, new List<string>());
                    //citiesByCountriesAndContinents[continent][country] = new List<string>();
                }

                citiesByCountriesAndContinents[continent][country].Add(city);                
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> citiesByCountriesInAContinent in citiesByCountriesAndContinents)
            {
                Console.WriteLine(citiesByCountriesInAContinent.Key + ":");
                foreach (KeyValuePair<string, List<string>> citiesInACountry in citiesByCountriesInAContinent.Value)
                {
                    Console.WriteLine($"  {citiesInACountry.Key} -> {string.Join(", ", citiesInACountry.Value)}");
                }
            }
        }
    }
}
