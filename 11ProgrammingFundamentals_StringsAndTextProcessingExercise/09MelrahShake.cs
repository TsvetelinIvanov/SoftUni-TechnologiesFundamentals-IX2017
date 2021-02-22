using System;

namespace _09MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            string pattern = Console.ReadLine();
            while(pattern.Length > 0)
            {
                int firstIndex = sequence.IndexOf(pattern);
                int lastIndex = sequence.LastIndexOf(pattern);                
                if (firstIndex >= 0 && lastIndex >= 0 || firstIndex != lastIndex)
                {
                    sequence = sequence.Remove(lastIndex, pattern.Length);
                    sequence = sequence.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");                   
                }
                else
                {
                    break;
                }

                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(sequence);
        }
    }
}
