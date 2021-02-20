using System;

namespace _03_EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            number = GetLastDigit(number);
            string[] numberNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine(numberNames[number]);
        }

        static long GetLastDigit(long n)
        {
            return Math.Abs(n % 10);
        }
    }
}
