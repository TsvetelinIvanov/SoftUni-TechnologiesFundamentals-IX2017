using System;

namespace _12MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && IsSumOfDigitsMultipleOfSeven(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            bool isPalindrome = false;
            for (int i = 0; i < numberString.Length / 2; i++)
            {                
                if (numberString[i] == numberString[(numberString.Length - 1) - i])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }

        static bool IsSumOfDigitsMultipleOfSeven(int number)
        {
            bool isSumOfDigitsMultipleOfSeven = false;
            int sum = 0;
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                sum += digit;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                isSumOfDigitsMultipleOfSeven = true;
            }

            return isSumOfDigitsMultipleOfSeven;
        }

        static bool ContainsEvenDigit(int number)
        {
            bool containsEvenDigit = false;            
            int digit = 1;
            while (number > 0)
            {
                digit = number % 10;
                if (digit % 2 == 0)
                {
                    containesEvenDigit = true;
                    break;
                }

                number /= 10;
            }

            return containsEvenDigit;
        }
    }
}
