using System.Collections.Generic;
using System.IO;

namespace _05MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("input.txt");
            using (streamReader)
            {
                Dictionary<string, int> resources = new Dictionary<string, int>();
                string resource = streamReader.ReadLine();
                while (resource != "stop")
                {
                    int quantity = int.Parse(streamReader.ReadLine());
                    if (!resources.ContainsKey(resource))
                    {
                        resources[resource] = 0;
                    }

                    resources[resource] += quantity;
                    
                    resource = streamReader.ReadLine();
                }

                string output = string.Empty;
                foreach (KeyValuePair<string, int> item in resources)
                {
                    output += $"{item.Key} -> {item.Value}\r\n";
                }

                File.WriteAllText("output", output);
            }
        }
    }
}
