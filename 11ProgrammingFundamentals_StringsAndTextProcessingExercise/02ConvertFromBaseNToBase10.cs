using System;
using System.Linq;
using System.Numerics;

namespace _02ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] BaseAndNumber = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse).ToArray();
            int @base = (int)BaseAndNumber[0];
            BigInteger number = BaseAndNumber[1];
            string numberToBase10 = DoNumberToBase10(number, @base);
            Console.WriteLine(numberToBase10);
        }

        static string DoNumberToBase10(BigInteger number, int @base)
        {
            string numberString = number.ToString();
            string reversedNumberString = Reverse(numberString);

            BigInteger numberToBase10 = 0;
            for (int i = 0; i < reversedNumberString.Length; i++)
            {
                numberToBase10 += int.Parse(reversedNumberString[i].ToString()) * BigInteger.Pow(@base, i);
            }

            return numberToBase10.ToString();
        }

        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            
            return new string(charArray);
        }
    }
}
