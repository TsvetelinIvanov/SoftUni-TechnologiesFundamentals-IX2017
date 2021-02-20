using System;
using System.Linq;

namespace _08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = nums.Length;
            do
            {
                for (int i = 0; i < length - 1; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }

                length--;
            } while (length > 1);

            Console.WriteLine(nums[0]);
        }
    }
}
