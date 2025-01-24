using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^0-9]+)(\d+)";
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            foreach (Match match in Regex.Matches(input, pattern))
            {
                string word = match.Groups[1].Value.ToUpper();
                int count = int.Parse(match.Groups[2].Value);                
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }

            int uniqueSymbolsCount = result.ToString().Distinct().Count();
            Console.WriteLine("Unique symbols used: " + uniqueSymbolsCount);
            Console.WriteLine(result.ToString());
        }
    }
}
