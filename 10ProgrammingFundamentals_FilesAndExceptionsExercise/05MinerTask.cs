using System.Collections.Generic;
using System.IO;

namespace _05MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");
            using (file)
            {
                Dictionary<string, int> resourses = new Dictionary<string, int>();
                string resourse = file.ReadLine();
                while (resourse != "stop")
                {
                    int quantity = int.Parse(file.ReadLine());
                    if (!resourses.ContainsKey(resourse))
                    {
                        resourses[resourse] = 0;
                    }

                    resourses[resourse] += quantity;
                    resourse = file.ReadLine();
                }

                string text = string.Empty;
                foreach (KeyValuePair<string, int> item in resourses)
                {
                    text += $"{item.Key} -> {item.Value}\r\n";
                }

                File.WriteAllText("output", text);
            }
        }
    }
}
