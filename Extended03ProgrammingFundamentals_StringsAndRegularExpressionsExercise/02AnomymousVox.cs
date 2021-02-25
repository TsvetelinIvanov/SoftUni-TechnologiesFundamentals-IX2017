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
            string[] placeholders = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //string[] placeholders = Regex.Split(Console.ReadLine(), "[{}]").Where(e => e != "").ToArray();
            MatchCollection matches = Regex.Matches(text, pattern);
            int count = 0;
            foreach (Match item in matches)
            {
                string newValue = item.Groups[1] + placeholders[count++] + item.Groups[3];
                text = text.Replace(item.Value, newValue);                
            }

            Console.WriteLine(text);
        }
    }
}
