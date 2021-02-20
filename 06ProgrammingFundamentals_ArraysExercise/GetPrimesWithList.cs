using System;
using System.Collections.Generic;

namespace GetPrimesWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<int> primes = GetPrimes(start, end);
            foreach(int prime in primes)
            {
                Console.WriteLine($"{prime} ");
            }
        }

        public static List<int> GetPrimes(int start, int end)
        {
            List<int> primesList = new List<int>();
            for (int number = start; number <= end; number++)
            {
                bool isPrime = true;
                double numberSqrt = Math.Sqrt(number);
                for (int divider = 2; divider <= numberSqrt; divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primesList.Add(number);
                }
            }

            return primesList;
        }
    }
}
