using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(new char[] { ' ', '/', '\\', ')', '(' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"^[A-Za-z]\w{2,24}$";
            List<string> validUsernames = new List<string>();
            foreach (string username in usernames)
            {
                if (Regex.IsMatch(username, pattern))
                {
                    validUsernames.Add(username);
                }
            }

            string first = string.Empty;
            string second = string.Empty;
            int length = 0;
            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                if (length < validUsernames[i].Length + validUsernames[i + 1].Length)
                {
                    length = validUsernames[i].Length + validUsernames[i + 1].Length;
                    first = validUsernames[i];
                    second = validUsernames[i + 1];
                }
            }

            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
