using System;
using System.Text.RegularExpressions;

namespace _03Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternSurface = $"^([^a-zA-Z0-9]+)$";
            string patternMantle = $"^([0-9_]+)$";
            string patternCore = $"^([a-zA-Z])$";
            string patternMiddle = $"^([^a-zA-Z0-9]+)([0-9_]+)([a-zA-Z]+)([0-9_]+)([^a-zA-Z0-9]+)$";
            bool isValid = true;

            string input1 = Console.ReadLine();
            Match match1 = Regex.Match(input1, patternSurface);
            if (!match1.Success)
            {
                isValid = false;
            }

            string input2 = Console.ReadLine();
            Match match2 = Regex.Match(input2, patternMantle);
            if (!match2.Success)
            {
                isValid = false;
            }                

            string input3 = Console.ReadLine();
            Match match3 = Regex.Match(input3, patternMiddle);
            if (!match3.Success)
            {
                isValid = false;
            }                

            string input4 = Console.ReadLine();
            Match match4 = Regex.Match(input4, patternMantle);
            if (!match4.Success)
            {
                isValid = false;
            }                

            string input5 = Console.ReadLine();
            Match match5 = Regex.Match(input5, patternSurface);
            if (!match5.Success)
            {
                isValid = false;
            }                

            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(match3.Groups[3].Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }            
        }
    }
}
