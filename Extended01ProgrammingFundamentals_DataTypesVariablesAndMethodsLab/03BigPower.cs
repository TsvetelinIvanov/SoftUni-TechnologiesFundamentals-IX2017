using System;
using System.Numerics;

namespace _03BigPower
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger poweredNumber = Power(number);
            Console.WriteLine(poweredNumber);
        }

        private static BigInteger Power(BigInteger number)
        {
            BigInteger powered = 1;
            for (int i = 1; i <= number; i++)
            {
                powered *= number;
            }

            return powered;
        }
    }
}
