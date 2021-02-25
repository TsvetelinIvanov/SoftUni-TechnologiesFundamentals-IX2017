using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {                             
            string pattern = @"(?:^| )\+359(-| )2\1\d{3}\1\d{4}\b"; 
            string phones = Console.ReadLine();
            MatchCollection phoneMatches = Regex.Matches(phones, pattern);
            string[] matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
