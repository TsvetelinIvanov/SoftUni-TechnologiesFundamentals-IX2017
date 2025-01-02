using System;
using System.Linq;

namespace _03FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primordial = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int oneQuarter = primordial.Length / 4;
            int[] leftQuarter = primordial.Take(oneQuarter).ToArray();
            int[] middleHalf = primordial.Skip(oneQuarter).Take(oneQuarter * 2).ToArray();
            int[] rightQuarter = primordial.Skip(oneQuarter * 3).Take(oneQuarter).ToArray();
            
            //The same result with two methods:
            Array.Reverse(leftQuarter);
            rightQuarter = rightQuarter.Reverse().ToArray();

            int[] folded = new int[oneQuarter * 2];
            for (int i = 0; i < oneQuarter; i++)
            {
                folded[i] = middleHalf[i] + leftQuart[i];
                folded[i + oneQuarter] = middleHalf[i + oneQuarter] + rightQuart[i];
            }

            Console.WriteLine(string.Join(" ", folded));
        }
    }
}
