using System;
using System.Collections.Generic;
using System.Linq;

namespace _10SrypskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> concerts = new Dictionary<string, Dictionary<string, long>>();
            string concertDataString = string.Empty;
            while ((concertDataString = Console.ReadLine()) != "End")
            {
                string[] rawConcertData = concertDataString.Split('@');
                if (rawConcertData[0].EndsWith(" ")) 
                {
                    string singer = rawConcertData[0].Trim();
                    
                    string[] venueData = rawConcertData[1].Split();
                    if (long.TryParse(venueData[venueData.Length - 1], out long ticketsCount) 
                        && long.TryParse(venueData[venueData.Length - 2], out long ticketPrice) 
                        && venueData.Length >= 3)
                    {
                        //long ticketsCount = long.Parse(venueData[venueData.Length - 1]);
                        //long ticketPrice = long.Parse(venueData[venueData.Length - 2]);
                        long ticketsIncom = ticketsCount * ticketPrice;
                        string venue = string.Empty;
                        for (int i = 0; i < venueData.Length - 2; i++)
                        {
                            venue += venueData[i] + " ";
                        }
                        
                        if (!concerts.ContainsKey(venue))
                        {
                            concerts.Add(venue, new Dictionary<string, long>());
                        }

                        if (!concerts[venue].ContainsKey(singer))
                        {
                            concerts[venue][singer] = 0;
                        }

                        concerts[venue][singer] += ticketsIncom;
                    }
                }
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> venue in concerts)
            {
                Console.WriteLine(venue.Key);
                foreach (KeyValuePair<string, long> singer in venue.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }            
        }        
    }
}
