using System;
using System.Linq;

namespace _08MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            
            int number = 0;
            int[] occurrences = new int[65535];
            int min = 0;
            int frequence = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                occurrences[numbers[i]]++;                
            }

            int max = occurrences.Max();
            for (int i = 0; i < occurrences.Length; i++)
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
