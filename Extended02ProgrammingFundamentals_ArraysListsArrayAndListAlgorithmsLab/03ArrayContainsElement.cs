using System;
using System.Linq;

namespace _03ArrayContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            
            bool isFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
