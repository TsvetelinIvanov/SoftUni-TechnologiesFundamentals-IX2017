using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string typePattern = "^Type: ((Normal)|(Warning)|(Danger))$";
            string sourcePattern = @"^Source: ([a-zA-Z0-9]+)$";
            string forecastPattern = @"^Forecast: ([^!.,?]+)$";
            
            string type = string.Empty;
            string source = string.Empty;
            string forecast = string.Empty;
            List<string> validForecasts = new List<string>();
            string validForecast = string.Empty;

            string input = Console.ReadLine();
            while (input != "Davai Emo")
            {
                Match typeMatch = Regex.Match(input, typePattern);
                if (typeMatch.Success && type == string.Empty)                
                {
                    type = typeMatch.Groups[1].Value;                    
                }

                Match sourceMatch = Regex.Match(input, sourcePattern);
                if (sourceMatch.Success && source == string.Empty && forecast == string.Empty && type != string.Empty)
                {
                    source = sourceMatch.Groups[1].Value;                    
                }

                Match forecastMatch = Regex.Match(input, forecastPattern);
                if (forecastMatch.Success && forecast == string.Empty && type != string.Empty && source != string.Empty)                
                {
                    forecast = forecastMatch.Groups[1].Value;                    
                }

                if (type != string.Empty && source != string.Empty && forecast != string.Empty)
                {
                    validForecast = $@"({type}) {forecast} ~ {source}";
                    validForecasts.Add(validForecast);
                    
                    type = string.Empty;
                    source = string.Empty;
                    forecast = string.Empty;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, validForecasts));
        }
    }
}
