using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            IEnumerable<string> numberedLines = lines.Select((line, index) => $"{index + 1}. {line}");
            File.WriteAllLines("output.txt", numberedLines);
        }
    }
}
