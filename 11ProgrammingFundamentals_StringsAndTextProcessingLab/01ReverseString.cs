using System;
using System.Linq;

namespace _01ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();                       
            string reversed = new string(charArray.Reverse().ToArray());
            Console.WriteLine(reversed);
            //or
            //Console.WriteLine(Console.ReadLine().Reverse().ToArray());
        }
    }
}
