using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?[0-9A-F]+\b";
            string numbers = Console.ReadLine();
            string[] hexadecimalNumbers = Regex.Matches(numbers, pattern)
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();
            Console.WriteLine(string.Join(" ", hexadecimalNumbers));
        }
    }
}
