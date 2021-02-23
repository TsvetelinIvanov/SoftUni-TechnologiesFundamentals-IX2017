using System;
using System.Numerics;

namespace _03BigPower
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger poweredN = Power(n);
            Console.WriteLine(poweredN);
        }

        private static BigInteger Power(BigInteger n)
        {
            BigInteger powered = 1;
            for (int i = 1; i <= n; i++)
            {
                powered *= n;
            }

            return powered;
        }
    }
}
