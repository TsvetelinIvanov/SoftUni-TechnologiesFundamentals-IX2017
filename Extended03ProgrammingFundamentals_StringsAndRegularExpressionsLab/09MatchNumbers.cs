using System;
using System.Text.RegularExpressions;

namespace _09MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.?\d+)?($|(?=\s))";
            string numbersString = Console.ReadLine();
            MatchCollection numbers = Regex.Matches(numbersString, pattern);
            foreach (Match number in numbers)
            {
                Console.Write(number + " ");               
                //Console.Write(number.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
