using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = Console.ReadLine()
                 .Split(new char[] { '|', '<', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            string patternKey = @"[A-Za-z]+";
            string start = keys[0];
            string startKey = string.Empty;
            Match startMatch = Regex.Match(start, patternKey);
            string startMatchString = startMatch.ToString();
            if (start == startMatchString)
            {
                startKey = start;
            }
            else
            {
                startKey = "This is not real key!";
            }

            string end = keys[keys.Length - 1];
            string endKey = string.Empty;
            Match endMatch = Regex.Match(end, patternKey);
            string endMatchString = endMatch.ToString();
            if (end == endMatchString)
            {
                endKey = end;
            }
            else
            {
                endKey = "This is not real key!";
            }

            string pattern = $@"(?<={startKey}).*?(?={endKey})";
            MatchCollection matches = Regex.Matches(text, pattern);
            StringBuilder resultStringBuilder = new StringBuilder();
            foreach (Match match in matches)
            {
                resultStringBuilder.Append(match);
            }

            string result = resultStringBuilder.ToString();
            if (result != string.Empty)
                Console.WriteLine(result);
            else
                Console.WriteLine("Empty result");
        }
    }
}
