using System;
using System.Linq;

namespace ExtractMiddleElementsIX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ExtractMiddleElements(nums);

        }

        static void ExtractMiddleElements(int[] numbers)
        {
            int numbersCount = numbers.Length;
            if (numbersCount == 1)
            {
                Console.WriteLine("{" + $" {numbers[0]} " + "}");
            }
            else if (numbersCount % 2 == 0)
            {
                Console.WriteLine("{" + $" {numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]} "  + "}");
            }
            else
            {
                Console.WriteLine("{" + $" {numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}, " +
                    $"{numbers[numbers.Length / 2 + 1]} " + "}");
            }
        }
    }
}
