using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b0?x?[0-9A-F]+\b";
            string name = Console.ReadLine();
            
            MatchCollection matches = Regex.Matches(name, pattern);
            string[] result = matches.Cast<Match>().Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
