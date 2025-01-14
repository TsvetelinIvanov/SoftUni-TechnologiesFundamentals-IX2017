using System;

namespace _02RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(words.Length);
                string word = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = word;
            }

            Console.WriteLine(string.Join($"{Environment.NewLine}", words));
        }
    }
}
