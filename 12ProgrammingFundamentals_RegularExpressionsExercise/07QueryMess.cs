using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();            
            while (input != "END")
            {
                Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
                string pattern = @"(^|(?<=[?&]))(?<key>.+?)\=(?<value>.+?)($|(?=[?&]))";
                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    string key = match.Groups["key"].ToString().Trim();
                    string value = match.Groups["value"].ToString().Trim();
                    string replacePattern = @"(\s|\+|%20)+";
                    key = Regex.Replace(key, replacePattern, " ").Trim();
                    if (key.Contains("?"))
                    {
                        string[] overloadedKey = key.Split(new char[] { '?' }, StringSplitOptions.RemoveEmptyEntries);
                        key = overloadedKey[1];
                    }

                    value = Regex.Replace(value, replacePattern, " ").Trim();
                    if (!output.ContainsKey(key))
                    {
                        output.Add(key, new List<string>());
                    }

                    output[key].Add(value);
                }
                
                foreach (KeyValuePair<string, List<string>> item in output)
                {
                    Console.Write(@"{0}=[{1}]", item.Key, string.Join(", ", item.Value));
                }

                Console.WriteLine();

                input = Console.ReadLine();
            }
        }        
    }
}
