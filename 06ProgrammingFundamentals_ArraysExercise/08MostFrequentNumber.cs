using System;
using System.Linq;

namespace _08MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int number = 0;
            int[] occurence = new int[65535];
            int min = 0;
            int frequence = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                occurence[numbers[i]]++;                
            }

            int max = occurence.Max();
            for (int i = 0; i < occurence.Length; i++)
            {
                if (max == occurence[i])
                {
                    number = i;
                    frequence++;
                }
            }

            if (frequence > 1)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        if (i < min)
                        {
                            min = i;
                        }
                    }
                }

                Console.WriteLine(numbers[min]);
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
