using System;

namespace _04CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            string string1 = strings[0];
            string string2 = strings[1];
            int sum = MultiplyAndSumCharacters(string1, string2);            
            Console.WriteLine(sum);
        }

        static int MultiplyAndSumCharacters(string string1, string string2)
        {
            int sum = 0;
            for (int i = 0; i < Math.Min(string1.Length, string2.Length); i++)
            {
                sum += string1[i] * string2[i];
            }

            for (int i = Math.Min(string1.Length, string2.Length); i < Math.Max(string1.Length, string2.Length); i++)
            {
                if (string1.Length > string2.Length)
                {
                    sum += string1[i];
                }
                else
                {
                    sum += string2[i];
                }                
            }

            return sum;
        }
    }
}
