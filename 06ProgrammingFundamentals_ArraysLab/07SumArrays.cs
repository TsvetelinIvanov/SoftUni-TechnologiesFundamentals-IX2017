using System;
using System.Linq;

namespace _07SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = Math.Max(firstArray.Length, secondArray.Length);            
            int[] sum = new int[max];
            for (int i = 0; i < max; i++)
            {
                sum[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
