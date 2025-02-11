using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }
        
        public string HatColor { get; set; }
        
        public int Physics { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] dwarfData = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
                string dwarfName = dwarfData[0];
                string dwarfHatColor = dwarfData[1];
                int dwarfPhysics = int.Parse(dwarfData[2]);                
                
                if (!dwarfs.Any(d => d.Name == dwarfName && d.HatColor == dwarfHatColor))
                {
                    Dwarf dwarf = new Dwarf
                    {
                        Name = dwarfName,
                        HatColor = dwarfHatColor,
                        Physics = dwarfPhysics
                    };

                    dwarfs.Add(dwarf);
                }
                else 
                {
                    Dwarf dwarf = dwarfs.Single(d => d.Name == dwarfName && d.HatColor == dwarfHatColor);
                    if (dwarf.Physics < dwarfPhysics)
                    {
                        dwarf.Physics = dwarfPhysics;
                    }
                }

                input = Console.ReadLine();
            }
           
            foreach (Dwarf dwarf in dwarfs.OrderByDescending(d => d.Physics).ThenByDescending(d => dwarfs.Where(dw => dw.HatColor == d.HatColor).Count()))
            {
               Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}
