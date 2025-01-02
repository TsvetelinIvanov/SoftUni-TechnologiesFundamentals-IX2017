using System;
using System.Linq;

namespace _02RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());
            int[] sums = new int[numbers.Length];
            for (int i = 0; i < rotationsCount; i++)
            {
                int lastElement = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = lastElement;
                
                for (int j = 0; j < numbers.Length; j++)
                {
                    sums[j] += numbers[j];
                }
            }

            Console.WriteLine(string.Join(" ", sums));           
        }
    }
}
