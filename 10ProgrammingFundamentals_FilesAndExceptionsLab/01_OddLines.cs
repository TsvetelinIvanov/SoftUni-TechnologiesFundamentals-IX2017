using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01_OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("lines.txt");
            IEnumerable<string> oddLines = lines.Where((line, index) => index % 2 == 1);
            File.WriteAllLines("odd-lines.txt", oddLines);
        }
    }
}
