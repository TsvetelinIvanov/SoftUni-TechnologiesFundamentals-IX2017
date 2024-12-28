using System;

namespace _03_EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int lastDigit = GetLastDigit(number);
            string[] numberNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine(numberNames[lastDigit]);
        }

        static long GetLastDigit(long n)
        {
            return Math.Abs(n % 10);
        }
    }
}
