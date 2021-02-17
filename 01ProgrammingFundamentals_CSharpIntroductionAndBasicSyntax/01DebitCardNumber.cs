using System;

namespace _01DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.Write("{0:d4} ", a);
            Console.Write("{0:d4} ", b);
            Console.Write("{0:d4} ", c);
            Console.Write("{0:d4} ", d);
        }
    }
}
