using System;
using System.Text.RegularExpressions;

namespace _03AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)(.*)(\1)";
            string text = Console.ReadLine();
            string[] placeholders = Console.ReadLine()
                .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            MatchCollection matches = Regex.Matches(text, pattern);
            int count = 0;
            foreach (Match match in matches)
            {
                string value = match.Groups[1].Value + placeholders[count++] + match.Groups[3].Value;
                text = text.Replace(match.Value, value);
            }

            Console.WriteLine(text);
        }
    }
}
