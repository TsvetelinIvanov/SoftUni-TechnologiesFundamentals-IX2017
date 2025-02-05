using System;

namespace _01ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            
            string reversedString = new String(charArray);
            Console.WriteLine(reversedString);
        }
    }
}
