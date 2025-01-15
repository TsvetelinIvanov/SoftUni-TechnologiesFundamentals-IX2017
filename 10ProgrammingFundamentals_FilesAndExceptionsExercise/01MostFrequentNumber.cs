using System;
using System.IO;
using System.Linq;

namespace _01MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] numbers = File.ReadAllText("input.txt").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            
            int number = 0;
            int mostFrequentNumber = 0;
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
                            mostFrequentNumber = number;
                        }
                    }
                }
            }
            
            File.WriteAllText("output.txt", mostFrequentNumber.ToString());
        }
    }
}
