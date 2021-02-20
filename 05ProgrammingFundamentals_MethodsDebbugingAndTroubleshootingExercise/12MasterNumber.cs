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
                if (IsPalindrome(i) && SumOfDigits(i) && ContainesEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int number)
        {
            string numberStr = number.ToString();
            bool isPalindrome = false;
            for (int i = 0; i < numberStr.Length / 2; i++)
            {                
                if (numberStr[i] == numberStr[(numberStr.Length - 1) - i])
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

        static bool SumOfDigits(int number)
        {
            bool isSumOfDigitsEqualToSeven = false;
            int sum = 0;
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                sum += digit;
                number /= 10;
            }

            if (sum % 7 == 0)
                isSumOfDigitsEqualToSeven = true;

            return isSumOfDigitsEqualToSeven;
        }

        static bool ContainesEvenDigit(int number)
        {
            bool containesEvenDigit = false;            
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

            return containesEvenDigit;
        }
    }
}
