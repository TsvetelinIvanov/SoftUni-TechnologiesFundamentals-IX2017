using System;

namespace _04NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            string numberString = "" + number;
            string reversed = ReverseDigits(numberString);
            Console.WriteLine(reversed);
        }

        static string ReverseDigits(string numberString)
        {
            string reversedNumberString = string.Empty;
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                reversedNumberString += numberString[i];
            }

            return reversedNumberString;
        }
    }
}
