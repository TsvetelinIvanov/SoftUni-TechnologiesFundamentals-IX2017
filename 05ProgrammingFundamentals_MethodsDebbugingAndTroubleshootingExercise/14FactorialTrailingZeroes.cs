using System;
using System.Numerics;

namespace _14FactorialTrailingZeroes
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = DoFactorial(n);
            int trailingZeroesCount = CountTrailingZeroes(factorial);
            Console.WriteLine(trailingZeroesCount);
        }

        static BigInteger DoFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static int CountTrailingZeroes(BigInteger number)
        {
            string numberString = number.ToString();
            int trailingZeroesCounter = 0;
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                if (numberString[i] == '0')
                {
                    trailingZeroesCounter++;
                }
                else
                {
                    break;
                }
            }

            return trailingZeroesCounter;
        }
    }
}
