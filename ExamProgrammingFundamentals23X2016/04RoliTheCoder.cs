using System;
using System.Collections.Generic;
using System.Linq;

namespace _04RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> eventsByIDs =
                new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Time for Code")
            {
                string[] requests = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);          
                if (requests.Length >= 2 && requests[1].StartsWith("#")) 
                {
                    string ID = requests[0];
                    string eventName = requests[1].Remove(0, 1);
                    if (!eventsByIDs.ContainsKey(ID))
                    {
                        eventsByIDs[ID] = new Dictionary<string, SortedSet<string>>();
                        eventsByIDs[ID][eventName] = new SortedSet<string>();
                        for (int i = 2; i < requests.Length; i++)
                        {
                            eventsByIDs[ID][eventName].Add(requests[i]);
                        }
                    }
                    else if (eventsByIDs[ID].ContainsKey(eventName))
                    {
                        for (int i = 2; i < requests.Length; i++)
                        {
                            eventsByIDs[ID][eventName].Add(requests[i]);
                        }
                    }
                }
            }

            Dictionary<string, SortedSet<string>> eventsByNames = new Dictionary<string, SortedSet<string>>();
            foreach (Dictionary<string, SortedSet<string>> eventByID in eventsByIDs.Values)
            {
                foreach (KeyValuePair<string, SortedSet<string>> eventByName in eventByID)
                {
                    eventsByNames.Add(eventByName.Key, eventByName.Value);
                }
            }

            foreach (KeyValuePair<string, SortedSet<string>> event1 in eventsByNames.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key))
            {
                Console.WriteLine($"{event1.Key} - {event1.Value.Count()}");
                foreach (string participant in event1.Value)
                {
                    Console.WriteLine(participant);
                }
            }
        }       
    }    
}
