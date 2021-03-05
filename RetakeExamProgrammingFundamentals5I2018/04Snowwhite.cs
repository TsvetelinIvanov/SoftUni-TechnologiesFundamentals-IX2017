using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Snowwhite
{    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] dwarfsData = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
                string dwarfName = dwarfsData[0];
                string dwarfHatColor = dwarfsData[1];
                int dwarfPhysics = int.Parse(dwarfsData[2]);
                string dwarfIdetity = dwarfName + " " + dwarfHatColor;
                if (!dwarfs.ContainsKey(dwarfIdetity))
                {
                    dwarfs.Add(dwarfIdetity, dwarfPhysics);
                }
                else if (dwarfs[dwarfIdetity] < dwarfPhysics)
                {
                    dwarfs[dwarfIdetity] = dwarfPhysics;
                }

                input = Console.ReadLine();
            }            

            Dictionary<string, int> dwarfHatColorCounts = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> dwarf in dwarfs)
            {
                string[] dwarfIdetity = dwarf.Key.Split();
                string dwarfHatColor = dwarfIdetity[1];
                if (!dwarfHatColorCounts.ContainsKey(dwarfHatColor))
                {
                    dwarfHatColorCounts.Add(dwarfHatColor, 0);
                }

                dwarfHatColorCounts[dwarfHatColor]++;
            }

            Dictionary<string, List<int>> dwarfsAndDwarfHatColorCounts =
                new Dictionary<string, List<int>>();
            foreach (KeyValuePair<string, int> dwarf in dwarfs)
            {
                string[] dwarfIdetity = dwarf.Key.Split();
                string dwarfHatColor = dwarfIdetity[1];
                dwarfsAndDwarfHatColorCounts[dwarf.Key] = new List<int>();
                dwarfsAndDwarfHatColorCounts[dwarf.Key].Add(dwarfHatColorCounts[dwarfHatColor]);
                dwarfsAndDwarfHatColorCounts[dwarf.Key].Add(dwarf.Value);
            }

            foreach (KeyValuePair<string, List<int>> dwarf in dwarfsAndDwarfHatColorCounts.OrderByDescending(d => d.Value[1]).ThenByDescending(d => d.Value[0]))
            {
                string[] dwarfIdetity = dwarf.Key.Split();
                string dwarfName = dwarfIdetity[0];
                string dwarfHatColor = dwarfIdetity[1];
                int dwarfPhysics = dwarf.Value[1];
                Console.WriteLine($"({dwarfHatColor}) {dwarfName} <-> {dwarfPhysics}");
            }
        }
    }
}
