using System;

namespace _09MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            int multipliedSums = GetMultipleOfEvensAndOdds(n);
            Console.WriteLine(multipliedSums);
        }

        private static int GetMultipleOfEvensAndOdds(int number)
        {
            number = Math.Abs(number);
            
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
