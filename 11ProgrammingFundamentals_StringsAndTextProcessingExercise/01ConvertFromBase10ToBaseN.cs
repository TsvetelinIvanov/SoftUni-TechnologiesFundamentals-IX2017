using System;
using System.Linq;
using System.Numerics;

namespace _01ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] baseAndNumber = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse).ToArray();
            int toBase = (int)baseAndNumber[0];
            BigInteger number = baseAndNumber[1];
            string numberToBase = DoNumberToBase(number, toBase);
            Console.WriteLine(numberToBase);
        }

        static string DoNumberToBase(BigInteger number, int toBase)
        {
            string numberStringBase = string.Empty;
            BigInteger numberReminder = 0;
            while (number > 0)
            {
                numberReminder = number % toBase;
                number = number / toBase;
                numberStringBase = numberReminder + numberStringBase;
            }
            
            return numberStringBase;
        }
    }
}
