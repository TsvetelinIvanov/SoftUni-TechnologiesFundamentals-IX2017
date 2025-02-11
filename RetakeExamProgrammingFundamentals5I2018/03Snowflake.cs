using System;
using System.Text.RegularExpressions;

namespace _03Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surfacePattern = $"^([^a-zA-Z0-9]+)$";
            string mantlePattern = $"^([0-9_]+)$";
            //string corePattern = $"^([a-zA-Z])$";
            string middlePattern = $"^([^a-zA-Z0-9]+)([0-9_]+)([a-zA-Z]+)([0-9_]+)([^a-zA-Z0-9]+)$";
            bool isValid = true;

            string surfaceInput = Console.ReadLine();
            Match surfaceMatch = Regex.Match(surfaceInput, surfacePattern);
            if (!surfaceMatch.Success)
            {
                isValid = false;
            }

            string mantleInput = Console.ReadLine();
            Match mantleMatch = Regex.Match(mantleInput, mantlePattern);
            if (!mantleMatch.Success)
            {
                isValid = false;
            }

            string middleInput = Console.ReadLine();
            Match middleMatch = Regex.Match(middleInput, middlePattern);
            if (!middleMatch.Success)
            {
                isValid = false;
            }

            string anotherMantleInput = Console.ReadLine();
            Match anotherMantleMatch = Regex.Match(anotherMantleInput, mantlePattern);
            if (!anotherMantleMatch.Success)
            {
                isValid = false;
            }

            string anotherSurfaceInput = Console.ReadLine();
            Match anotherSurfaceMatch = Regex.Match(anotherSurfaceInput, surfacePattern);
            if (!anotherSurfaceMatch.Success)
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(middleMatch.Groups[3].Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }            
        }
    }
}
