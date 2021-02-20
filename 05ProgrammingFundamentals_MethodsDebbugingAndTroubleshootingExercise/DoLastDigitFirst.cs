using System;

namespace DoLastDigitFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            string numberString = "" + number;
            string numberWithReversedLastDigitString = ReverseLastDigit(numberString);
            Console.WriteLine(numberWithReversedLastDigitString);
        }

        static string ReverseLastDigit(string numberString)
        {
            string numberWithReversedLastDigitString = string.Empty;
            //for (int i = 0; i <= numberString.Length - 2; i++)
            //{

            //    numberWithReversedLastDigitString += numberString[i]; 
            //}
            numberWithReversedLastDigitString = numberString.Remove(numberString.Length - 1);
            numberWithReversedLastDigitString = numberString[numberString.Length - 1] + numberWithReversedLastDigitString;
            if (numberWithReversedLastDigitString[numberWithReversedLastDigitString.Length - 1] == '.')
            {
                numberWithReversedLastDigitString = numberWithReversedLastDigitString.Remove(numberWithReversedLastDigitString.Length - 1);
            }

            return numberWithReversedLastDigitString;
        }
    }
}
