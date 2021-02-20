using System;

namespace _06SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;// or long, or double, or decimal.
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReverseDigits(numbers[i]);
                sum += int.Parse(numbers[i]);           
            }       
            
            Console.WriteLine(sum);
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
