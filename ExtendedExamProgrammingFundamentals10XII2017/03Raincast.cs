using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternType = "^Type: ((Normal)|(Warning)|(Danger))$";
            string patternSource = @"^Source: ([a-zA-Z0-9]+)$";
            string patternForecast = @"^Forecast: ([^!.,?]+)$";            
            string type = string.Empty;
            string source = string.Empty;
            string forecast = string.Empty;
            List<string> validForecasts = new List<string>();
            string validForecast = string.Empty;

            string input = Console.ReadLine();
            while (input != "Davai Emo")
            {
                Match matchType = Regex.Match(input, patternType);

                if (matchType.Success && type == string.Empty)                
                {
                    type = matchType.Groups[1].Value;                    
                }

                Match matchSource = Regex.Match(input, patternSource);
                if (matchSource.Success && source == string.Empty && forecast == string.Empty && type != string.Empty)
                {
                    source = matchSource.Groups[1].Value;                    
                }

                Match matchForecast = Regex.Match(input, patternForecast);
                if (matchForecast.Success && type != string.Empty && source != string.Empty && forecast == string.Empty)                
                {
                    forecast = matchForecast.Groups[1].Value;                    
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
