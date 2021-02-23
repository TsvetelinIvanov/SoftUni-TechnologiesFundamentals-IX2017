using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string weatherPattern = @"([A-Z]{2})(-?\d+\.\d+)([A-Za-z]+)\|"; //or (?=\|) instead \|
            Regex regex = new Regex(weatherPattern);
            string input = Console.ReadLine();
            Dictionary<string, KeyValuePair<double, string>> weatherForecasts = 
                new Dictionary<string, KeyValuePair<double, string>>();
            while (input != "end")
            {
                bool validForecast = regex.IsMatch(input);
                if (validForecast)
                {
                    Match match = regex.Match(input);
                    string city = match.Groups[1].Value;
                    double temperature = double.Parse(match.Groups[2].Value);
                    string weatherType = match.Groups[3].Value;
                    if (weatherForecasts.ContainsKey(city))
                    {
                        weatherForecasts[city] = new KeyValuePair<double, string>(temperature, weatherType);
                    }
                    else
                    {
                        weatherForecasts.Add(city, new KeyValuePair<double, string>(temperature, weatherType));
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, KeyValuePair<double, string>> weatherForecast in weatherForecasts.OrderBy(w => w.Value.Key))
            {
                Console.WriteLine("{0} => {1:f2} => {2}", weatherForecast.Key, weatherForecast.Value.Key, 
                    weatherForecast.Value.Value);
            }
        }
    }
}
