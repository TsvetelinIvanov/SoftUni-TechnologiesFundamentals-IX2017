using System;
using System.Text.RegularExpressions;

namespace _02AnomymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)(.*)(\1)";
            string text = Console.ReadLine();
            string[] replacements = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //string[] replacements = Regex.Split(Console.ReadLine(), "[{}]").Where(r => r != "").ToArray();
            MatchCollection matches = Regex.Matches(text, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                string replacement = match.Groups[1] + replacements[count++] + match.Groups[3];
                text = text.Replace(match.Value, replacement);                
            }

            Console.WriteLine(text);
        }
    }
}
