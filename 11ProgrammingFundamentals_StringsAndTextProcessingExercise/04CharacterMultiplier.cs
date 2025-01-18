using System;

namespace _04CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstString = strings[0];
            string secondString = strings[1];
            
            int sum = MultiplyAndSumCharacters(string1, secondString);            
            Console.WriteLine(sum);
        }

        static int MultiplyAndSumCharacters(string firstString, string secondString)
        {
            int sum = 0;
            for (int i = 0; i < Math.Min(firstString.Length, secondString.Length); i++)
            {
                sum += firstString[i] * secondString[i];
            }

            for (int i = Math.Min(firstString.Length, secondString.Length); i < Math.Max(firstString.Length, secondString.Length); i++)
            {
                if (firstString.Length > secondString.Length)
                {
                    sum += firstString[i];
                }
                else
                {
                    sum += secondString[i];
                }                
            }

            return sum;
        }
    }
}
