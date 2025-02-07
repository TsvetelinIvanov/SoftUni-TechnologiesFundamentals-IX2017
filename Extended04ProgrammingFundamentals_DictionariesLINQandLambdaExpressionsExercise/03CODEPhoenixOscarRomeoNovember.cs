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
            List<string> checks = new List<string>();
            
            string input = Console.ReadLine();
            while (input != "Blaze it!")
            {
                string[] creatureData = input.Split(new string[] { " -> " }, StringSplitOptions.None);
                string squadLeader = creatureData[0];
                string squadMate = creatureData[1];
                checks.Add(squadMate + "" + squadLeader);
                
                if (!squads.ContainsKey(squadLeader) && squadMate != squadLeader)
                {
                    squads.Add(squadLeader, new List<string>());
                    if (checks.Contains(squadLeader + "" + squadMate))
                    {
                        squads[squadMate].Remove(squadLeader);
                        input = Console.ReadLine();

                        continue;
                    }

                    squads[squadLeader].Add(squadMate);
                }
                else if (!squads[squadLeader].Contains(squadMate) && squadMate != squadLeader)
                {
                    if (checks.Contains(squadLeader + "" + squadMate))
                    {
                        squads[squadMate].Remove(squadLeader);
                        input = Console.ReadLine();

                        continue;
                    }

                    squads[squadLeader].Add(squadMate);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> squad in squads.OrderByDescending(s => s.Value.Count))
            {
                Console.WriteLine("{0} : {1}", squad.Key, squad.Value.Count);
            }
        }
    }
}
