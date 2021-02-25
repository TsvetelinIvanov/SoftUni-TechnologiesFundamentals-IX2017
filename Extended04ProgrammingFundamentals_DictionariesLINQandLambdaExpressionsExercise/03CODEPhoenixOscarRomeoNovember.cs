using System;
using System.Collections.Generic;
using System.Linq;

namespace _03CODEPhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> squads = new Dictionary<string, List<string>>();
            List<string> check = new List<string>();
            string input = Console.ReadLine();
            while (input != "Blaze it!")
            {
                string[] creatures = input.Split(new string[] { " -> " }, StringSplitOptions.None);
                string creature = creatures[0];
                string squadMate = creatures[1];
                check.Add(squadMate + "" + creature);
                if (!squads.ContainsKey(creature) && squadMate != creature)
                {
                    squads.Add(creature, new List<string>());
                    if (check.Contains(creature + "" + squadMate))
                    {
                        squads[squadMate].Remove(creature);
                        input = Console.ReadLine();

                        continue;
                    }

                    squads[creature].Add(squadMate);
                }
                else if (!squads[creature].Contains(squadMate) && squadMate != creature)
                {
                    if (check.Contains(creature + "" + squadMate))
                    {
                        squads[squadMate].Remove(creature);
                        input = Console.ReadLine();

                        continue;
                    }

                    squads[creature].Add(squadMate);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> squad in squads.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine("{0} : {1}", squad.Key, squad.Value.Count);
            }
        }
    }
}
