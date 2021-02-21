using System;
using System.IO;

namespace _07AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] autors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(File.ReadAllText("input.txt"));
            Random phraseIndex = new Random();
            Random eventIndex = new Random();
            Random autorIndex = new Random();
            Random cityIndex = new Random();
            string text = string.Empty;
            for (int i = 0; i < n; i++)
            {
               text += ($"{phrases[phraseIndex.Next(phrases.Length)]} " +
                    $"{events[eventIndex.Next(events.Length)]} {autors[autorIndex.Next(autors.Length)]} - " +
                    $"{cities[cityIndex.Next(cities.Length)]}\r\n");
            }

            File.WriteAllText("otput.txt", text);
        }
    }
}
