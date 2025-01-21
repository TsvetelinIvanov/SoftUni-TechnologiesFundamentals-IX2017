using System;
using System.Text.RegularExpressions;

namespace _05MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?(\d+|\d+\.\d+)($|(?=\s))";
            string name = Console.ReadLine();
            
            MatchCollection matches = Regex.Matches(name, pattern);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
