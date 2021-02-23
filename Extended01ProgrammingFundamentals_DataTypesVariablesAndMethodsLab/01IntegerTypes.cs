using System;

namespace _01IntegerTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            uint b = uint.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);
        }
    }
}
