using System;
using System.Text.RegularExpressions;

namespace _01MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z]{1}[a-z]+\b");
            string names = Console.ReadLine();
            MatchCollection maches = regex.Matches(names);
            foreach (Match name in maches)
            {
                Console.Write(name.Value + " ");
            }
        }
    }
}
