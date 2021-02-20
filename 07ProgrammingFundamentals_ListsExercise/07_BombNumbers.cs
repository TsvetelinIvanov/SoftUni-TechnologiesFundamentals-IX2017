using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] bomb = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int sum = 0;
            int bombNumber = bomb[0];
            int radius = bomb[1];            
           
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    if (0 > i - radius || i + radius >= numbers.Count)
                    {
                        if (0 > i - radius && i + radius  >= numbers.Count)
                        {
                            numbers.RemoveRange(0, numbers.Count);
                        }
                        else if (0 > i - radius)
                        {
                            numbers.RemoveRange(0, i + radius + 1);
                        }
                        else if (i + radius >= numbers.Count)
                        {
                            numbers.RemoveRange(i - radius, numbers.Count - i + radius);
                        }
                    }
                    else
                    {
                        numbers.RemoveRange(i - radius, radius * 2 + 1);
                    }

                    i -= 1;
                }               
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);       
        }
    }
}
