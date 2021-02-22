using System;
using System.Linq;

namespace _08LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (string str in input)
            {
                char firstLetter = str.First();
                char lastLetter = str.Last();
                double number = double.Parse(str.Substring(1, str.Length - 2));
                number = DoFirstLetterCalculation(firstLetter, number);
                number = DoLastLetterCalculation(lastLetter, number);
                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }

        static double DoFirstLetterCalculation(char firstLetter, double number)
        {
            if (char.IsUpper(firstLetter))
            {
                number /= (firstLetter - 'A' + 1);
            }
            else if (char.IsLower(firstLetter))
            {
                number *= (firstLetter - 'a' + 1);
            }

            return number;
        }

        static double DoLastLetterCalculation(char lastLetter, double number)
        {
            if (char.IsUpper(lastLetter))
            {
                number -= lastLetter - 'A' + 1;
            }
            else if (char.IsLower(lastLetter))
            {
                number += lastLetter - 'a' + 1;
            }

            return number;
        }
    }
}
