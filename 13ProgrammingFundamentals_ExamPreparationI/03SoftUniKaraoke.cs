using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedSet<string>> listedAwards = new Dictionary<string, SortedSet<string>>();
            string pattern = @",\s+";
            string[] listedParticipants = Regex.Split(Console.ReadLine(), pattern);
            string[] listedSongs = Regex.Split(Console.ReadLine(), pattern);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] performings = Regex.Split(input, pattern);
                string participant = performings[0];
                string song = performings[1];
                string award = performings[2];
                if (listedParticipants.Contains(participant) && listedSongs.Contains(song))
                {
                    if (!listedAwards.ContainsKey(participant))
                    {
                        listedAwards.Add(participant, new SortedSet<string>());
                    }

                    listedAwards[participant].Add(award);
                }
            }

            if (listedAwards.Count == 0)
            {
                Console.WriteLine("No awards");
                
                return;
            }                

            foreach (KeyValuePair<string, SortedSet<string>> awarded in listedAwards.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key)) 
            {
                Console.WriteLine($"{awarded.Key}: {awarded.Value.Count} awards");
                Console.Write("--");
                Console.WriteLine(string.Join("\r\n--", awarded.Value));
            }
        }
    }
}
