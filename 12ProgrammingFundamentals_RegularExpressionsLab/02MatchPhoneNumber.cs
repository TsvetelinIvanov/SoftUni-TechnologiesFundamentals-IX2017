using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(^| )\+359(-| )2\2\d{3}\2\d{4}\b");
            string name = Console.ReadLine();
            
            MatchCollection matches = regex.Matches(name);
            string[] result = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
