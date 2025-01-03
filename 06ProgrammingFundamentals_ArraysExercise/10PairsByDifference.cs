using System;
using System.Linq;

namespace _10PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            
            int counter = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                for (int j = 0; j <= numbers.Length - 1; j++)
                {
                    if (numbers[i] - numbers[j] == difference)
                    {
                        counter++;                        
                    }
                }
            }

            if (difference == 0)
            {
                counter -= numbers.Length;
            }

            Console.WriteLine(counter);
        }
    }
}
