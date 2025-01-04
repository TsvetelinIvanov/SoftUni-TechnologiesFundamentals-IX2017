using System;
using System.Linq;

namespace _08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = numbers.Length;
            do
            {
                for (int i = 0; i < length - 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                }

                length--;
            } while (length > 1);

            Console.WriteLine(numbers[0]);
        }
    }
}
