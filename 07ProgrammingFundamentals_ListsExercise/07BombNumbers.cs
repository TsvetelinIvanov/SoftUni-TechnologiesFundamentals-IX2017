using System;
using System.Collections.Generic;
using System.Linq;

namespace _07BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bomb = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> survivels = new List<int>();
            int sum = 0;
            int bombNumber = bomb[0];
            int radius = bomb[1];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    for (int j = i - radius; j <= i + radius; j++)
                    {
                        if (j >= 0 && j < numbers.Length)
                        {
                            numbers[j] = -1;//if -1 is in numbers[], it don't work - change with somting else!
                        }
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != -1)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
