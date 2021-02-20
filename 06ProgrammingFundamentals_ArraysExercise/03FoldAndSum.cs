using System;
using System.Linq;

namespace _03FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primordial = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = primordial.Length / 4;
            int[] leftQuart = primordial.Take(k).ToArray();
            int[] middleHalf = primordial.Skip(k).Take(k * 2).ToArray();
            int[] rightQuart = primordial.Skip(k * 3).Take(k).ToArray();
            Array.Reverse(leftQuart);
            rightQuart = rightQuart.Reverse().ToArray(); //The same result with two methods.

            int[] folded = new int[k * 2];
            for (int i = 0; i < k; i++)
            {
                folded[i] = middleHalf[i] + leftQuart[i];
                folded[i + k] = middleHalf[i + k] + rightQuart[i];
            }

            Console.WriteLine(string.Join(" ", folded));
        }
    }
}
