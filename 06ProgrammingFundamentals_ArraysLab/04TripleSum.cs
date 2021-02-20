using System;
using System.Linq;

namespace _04TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            int[] numbers = values.Split(' ').Select(int.Parse).ToArray();
            
            bool isSum = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                        if (numbers.Contains(sum))
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                            isSum = true;
                        }                    
                }
            }

            if (!isSum)
                Console.WriteLine("No");
        }
    }
}
