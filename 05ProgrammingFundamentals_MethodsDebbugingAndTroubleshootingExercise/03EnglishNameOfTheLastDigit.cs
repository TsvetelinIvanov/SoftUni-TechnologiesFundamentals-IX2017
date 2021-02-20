using System;

namespace _03EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long nAbs = Math.Abs(n);
            Console.WriteLine(DoLastDigitInWord(nAbs));
        }

        static string DoLastDigitInWord(long number)
        {
            number %= 10;
            string lastDigit = string.Empty;
            switch (number)
            {
                case 0:
                    lastDigit = "zero";
                    break;
                case 1:
                    lastDigit = "one";
                    break;
                case 2:
                    lastDigit = "two";
                    break;
                case 3:
                    lastDigit = "three";
                    break;
                case 4:
                    lastDigit = "four";
                    break;
                case 5:
                    lastDigit = "five";
                    break;
                case 6:
                    lastDigit = "six";
                    break;
                case 7:
                    lastDigit = "seven";
                    break;
                case 8:
                    lastDigit = "eight";
                    break;
                case 9:
                    lastDigit = "nine";
                    break;                
            }

            return lastDigit;
        }
    }
}
