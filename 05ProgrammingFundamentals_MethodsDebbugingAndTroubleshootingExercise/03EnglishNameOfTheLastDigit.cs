using System;

namespace _03EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long positiveNumber = Math.Abs(number);
            Console.WriteLine(MakeLastDigitInWord(positiveNumber));
        }

        static string MakeLastDigitInWord(long number)
        {
            lastDigit %= 10;
            string lastDigitString = string.Empty;
            switch (lastDigit)
            {
                case 0:
                    lastDigitString = "zero";
                    break;
                case 1:
                    lastDigitString = "one";
                    break;
                case 2:
                    lastDigitString = "two";
                    break;
                case 3:
                    lastDigitString = "three";
                    break;
                case 4:
                    lastDigitString = "four";
                    break;
                case 5:
                    lastDigitString = "five";
                    break;
                case 6:
                    lastDigitString = "six";
                    break;
                case 7:
                    lastDigitString = "seven";
                    break;
                case 8:
                    lastDigitString = "eight";
                    break;
                case 9:
                    lastDigitString = "nine";
                    break;                
            }

            return lastDigitString;
        }
    }
}
