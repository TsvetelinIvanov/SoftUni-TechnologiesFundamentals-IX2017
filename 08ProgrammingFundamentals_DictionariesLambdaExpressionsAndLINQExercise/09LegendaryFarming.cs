using System;
using System.Collections.Generic;
using System.Linq;

namespace _09LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryMaterials = new Dictionary<string, int>();
            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();
            legendaryMaterials["shards"] = 0;
            legendaryMaterials["fragments"] = 0;
            legendaryMaterials["motes"] = 0;
            bool isObtainedShadowmourne = false;
            bool isObtainedValanyr = false;
            bool isObtainedDragonwrath = false;

            while (true)
            {
                string[] materials = Console.ReadLine().ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < materials.Length; i += 2)
                {
                    int quantity = int.Parse(materials[i]);
                    string material = materials[i + 1];

                    if (material == "shards")
                    {
                        legendaryMaterials["shards"] += quantity;
                        if (legendaryMaterials["shards"] >= 250)
                        {
                            legendaryMaterials["shards"] -= 250;
                            isObtainedShadowmourne = true;
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        legendaryMaterials["fragments"] += quantity;
                        if (legendaryMaterials["fragments"] >= 250)
                        {
                            legendaryMaterials["fragments"] -= 250;
                            isObtainedValanyr = true;
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        legendaryMaterials["motes"] += quantity;
                        if (legendaryMaterials["motes"] >= 250)
                        {
                            legendaryMaterials["motes"] -= 250;
                            isObtainedDragonwrath = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }

                }

                if (isObtainedShadowmourne || isObtainedValanyr || isObtainedDragonwrath)
                    break;
            }

            if (isObtainedShadowmourne)
            {
                Console.WriteLine("Shadowmourne obtained!");
            }

            if (isObtainedValanyr)
            {
                Console.WriteLine("Valanyr obtained!");
            }

            if (isObtainedDragonwrath)
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            foreach (KeyValuePair<string, int> legendaryMaterial in legendaryMaterials.OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
            {
                Console.WriteLine(legendaryMaterial.Key + ": " + legendaryMaterial.Value);
            }

            foreach (KeyValuePair<string, int> junkMaterial in junkMaterials)
            {
                Console.WriteLine(junkMaterial.Key + ": " + junkMaterial.Value);
            }
        }
    }
}
