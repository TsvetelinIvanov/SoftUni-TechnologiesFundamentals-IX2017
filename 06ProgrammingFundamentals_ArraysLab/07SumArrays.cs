using System;
using System.Linq;

namespace _07SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = Math.Max(arr1.Length, arr2.Length);
            int[] sum = new int[max];
            for (int i = 0; i < max; i++)
            {
                sum[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
