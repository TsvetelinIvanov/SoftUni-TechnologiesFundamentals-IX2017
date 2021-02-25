using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int filesCount = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, long>> allFiles = 
                new Dictionary<string, SortedDictionary<string, long>>();
            for (int i = 0; i < filesCount; i++)
            {
                string[] fileData = Console.ReadLine().Split(';');
                long size = long.Parse(fileData[1]);
                int index = fileData[0].LastIndexOf('\\');
                string name = fileData[0].Substring(index + 1);
                index = fileData[0].IndexOf('\\');
                string root = fileData[0].Substring(0, index);
                if (!allFiles.ContainsKey(root))
                {
                    allFiles.Add(root, new SortedDictionary<string, long>());
                }

                if (!allFiles[root].ContainsKey(name))
                {
                    allFiles[root].Add(name, size);
                }
                else
                {
                    allFiles[root][name] = size;
                }                
            }

            string[] filter = Console.ReadLine().Split(' ');
            string rootFilter = filter[2];
            string extension = filter[0];            
            bool isFound = false;
            foreach (KeyValuePair<string, SortedDictionary<string, long>> root in allFiles.Where(x => x.Key == rootFilter))
            {
                foreach (KeyValuePair<string, long> file in root.Value
                    .Where(x => x.Key.Substring(x.Key.LastIndexOf('.') + 1) == extension)
                    .OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("{0} - {1} KB", file.Key, file.Value);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
