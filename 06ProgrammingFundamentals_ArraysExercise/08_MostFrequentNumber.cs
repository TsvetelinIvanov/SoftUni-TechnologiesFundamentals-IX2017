using System;
using System.Linq;

namespace _08_MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            
            int number = 0;
            int max = 0;
            int counter = 0;
            int frequence = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                counter = 0;
                for (int j = 0; j <= numbers.Length - 1; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        number = numbers[i];
                        if (frequence < counter)
                        {
                            frequence = counter;
                            max = number;
                        }
                    }
                }
            }

            Console.WriteLine(max);
        }
    }
}
