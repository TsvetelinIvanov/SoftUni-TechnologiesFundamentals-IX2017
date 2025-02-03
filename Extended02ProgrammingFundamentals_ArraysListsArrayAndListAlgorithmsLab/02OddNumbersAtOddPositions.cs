using System;
using System.Linq;

namespace _02OddNumbersAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            for (int i = 1; i <= numbers.Length - 1; i += 2)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine("Index {0} -> {1}", i, numbers[i]);
                }
            }
            
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i % 2 == 1 && Math.Abs(numbers[i] % 2) == 1)
            //    {
            //        Console.WriteLine("Index {0} -> {1}", i, numbers[i]);
            //    }
            //}
        }
    }
}
