using System;

namespace _06PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long number)
        {
            bool isPrime = true;
            int divider = 2;
            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
                
            for (int i = 2; i <= (long)Math.Sqrt(number); i++)
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                    break;
                }

                divider++;
            }

            return isPrime;
        }
    }
}
