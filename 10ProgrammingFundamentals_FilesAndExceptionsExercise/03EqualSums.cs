using System;
using System.IO;
using System.Linq;

namespace _03EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("input.txt").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            
            bool isFound = false;
            string numberString = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] left = numbers.Take(i).ToArray();
                int[] right = numbers.Skip(i + 1).ToArray();
                if (left.Sum() == right.Sum())
                {
                    numberString = i.ToString();
                    isFound = true;
                }
            }

            if (isFound)
            {
                File.WriteAllText("output.txt", numberString);
            }
            else
            {
                File.WriteAllText("output.txt", "no");
            }                
        }
    }
}
